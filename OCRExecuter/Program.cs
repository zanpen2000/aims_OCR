using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using DBHelper;
using System.Data.SqlClient;
using ExtensionsLib;

namespace OCRHelper
{
    class Program
    {
        /*
         从数据库获取图片路径，识别，存入数据库表
         
         */

        static void Main(string[] args)
        {
            string cstring = AppSettings.Get("ConnectionString");
            DBHelper.MyDBHelper.InitConnectionString(cstring);

            OCRHelper ocr = new OCRHelper();
            ocr.OnOCRProcessing += ocr_OnOCRProcessing;
            ocr.OnOCRCompleted += ocr_OnOCRCompleted;

            string sql = @"select * from domainCommentImage where isdelete=0 and ocred=0";
            var imageReader = MyDBHelper.QueryReader(sql);
            while (imageReader.Read())
            {
                string imgId = imageReader["id"].ToString();
                string imgPath = imageReader["img_path"].ToString();
                ocr.Go(imgId, imgPath);
            }
        }

        static void ocr_OnOCRProcessing(object sender, OCRProcessingEventArgs e)
        {
            Console.WriteLine("{0}\t{1}", e.ImageId, e.Text);
        }

        static void ocr_OnOCRCompleted(object sender, OCRProcessingEventArgs e)
        {
            if (InsertOCR(e.ImageId, e.Text) > 0) UpdateOCRStatus(e.ImageId);
        }

        private static int InsertOCR(string imgId, string text)
        {
            text = text.Replace("'", "");
            string sql = string.Format(@"insert into domainOCRText (id, imageId, text, luceneindexed, isDelete,createDate, modifyDate) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                GetMaxId("domainOCRText"),
                imgId,
                text,
                false,
                false,
                DateTime.Now.ToString(),
                DateTime.Now.ToString()
                );

            return MyDBHelper.Execute(sql);
        }

        private static void UpdateOCRStatus(string imgId)
        {
            string uptsql = string.Format(@"update domainCommentImage set ocred='1' where id='{0}'", imgId);
            MyDBHelper.Execute(uptsql);
        }

        private static string GetMaxId(string tablename)
        {
            var conn = MyDBHelper.GetConnection();
            var cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.CommandText = "GetSysMaxID2";
            cmd.Parameters.Add("@systemName", System.Data.SqlDbType.VarChar, 50);
            cmd.Parameters.Add("@systemLength", System.Data.SqlDbType.Int, 10);
            cmd.Parameters.Add(new SqlParameter()
            {
                ParameterName = "@systemValue",
                Direction = System.Data.ParameterDirection.Output,
                DbType = System.Data.DbType.String,
                Size = 10
            });

            cmd.Parameters["@systemName"].Value = tablename;
            cmd.Parameters["@systemLength"].Value = 10;

            conn.Open();
            int rowsAffected = cmd.ExecuteNonQuery();

            string result = cmd.Parameters["@systemValue"].Value.ToString();
            return result;
        }
    }
}
