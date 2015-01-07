using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{
    using Lucene.Net.Documents;
    using ExtensionsLib;
    using System.Reflection;
    using System.Data.SqlClient;
    using DBHelper;

    /// <summary>
    /// 实现IGetLuceneDocs接口的业务对象
    /// </summary>
    public class ArticleDetailDocument : IGetLuceneDocs
    {

        public ArticleDetailDocument()
        {

        }

        /// <summary>
        /// 顺序流程:读取数据库记录，OCR扫描，结果入库并分词，建立索引
        /// </summary>
        /// <param name="isCreate"></param>
        /// <returns></returns>
        public Documents GetDocuments(bool isCreate)
        {
            var action = GetRecords(isCreate);

            Documents docs = new Documents();
            foreach (var row in action)
            {
                Document doc = new Document();

                var ps = PropertyHelper<Article>.GetPropertys();
                foreach (var t in ps)
                {
                    var attr = System.Attribute.GetCustomAttribute(t, typeof(Attributes.FieldAttribute)) as Attributes.FieldAttribute;
                    var isField = t.IsDefined(typeof(Attributes.FieldAttribute), false);
                    string value = row[t.Name].StringValue();
                    if (!string.IsNullOrEmpty(value) && isField)
                    {
                        doc.Add(new Field(t.Name, value, attr.Store, attr.Index));
                    }
                }

                docs.Add(doc);

                //更新索引标记
                UpdateLuceneIndexStatus(row, true);
            }
            return docs;
        }

        /// <summary>
        /// 操作指定的ImageId
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public Documents GetDocuments(IEnumerable<string> ids)
        {
            Documents docs = new Documents();

            var action = GetRecords(ids);

            foreach (var row in action)
            {
                Document doc = new Document();

                var ps = PropertyHelper<Article>.GetPropertys();

                foreach (var t in ps)
                {
                    var attr = System.Attribute.GetCustomAttribute(t, typeof(Attributes.FieldAttribute)) as Attributes.FieldAttribute;
                    var isField = t.IsDefined(typeof(Attributes.FieldAttribute), false);
                    string value = row[t.Name].StringValue();
                    if (!string.IsNullOrEmpty(value) && isField)
                        doc.Add(new Field(t.Name, value, attr.Store, attr.Index));
                }

                docs.Add(doc);

                //更新索引标记
                UpdateLuceneIndexStatus(row, true);
            }
            return docs;
        }

        private OrganizationInfo __getOrganizationInfo(string organization)
        {
            string sql = string.Format(@"select * from codeOrganization where id='{0}'", organization);
            var dt = MyDBHelper.Query(sql);
            if (dt != null && dt.Rows.Count == 1)
            {
                return new OrganizationInfo()
                {
                    Code = dt.Rows[0]["organizName"].StringValue(),
                    Name = dt.Rows[0]["description"].StringValue()
                };
            }
            else return null;
        }

        private void UpdateLuceneIndexStatus(Article dto, bool p)
        {
            string uptsql = string.Format(@"update domainOCRText set luceneIndexed='1' where imageid='{0}'", dto.imageid);
            string uptsql2 = string.Format(@"update domainCommentImage  set luceneIndexed=1 where id='{0}'", dto.imageid);
            MyDBHelper.Execute(uptsql);
            MyDBHelper.Execute(uptsql2);
        }

        private IEnumerable<Article> GetRecords(bool reindex = false)
        {
            List<Article> articles = new List<Article>();

            string sql = @"select * from domainCommentImage where isdelete = 0 and ocred = 1";

            if (!reindex) // 是否重建索引
                sql += " and luceneIndexed = 0";

            var imageReader = MyDBHelper.QueryReader(sql);
            while (imageReader.Read())
            {
                Article article = new Article();
                article.imageid = imageReader["id"].StringValue();
                article.volumeid = imageReader["attachId"].StringValue();
                article.catalogid = imageReader["catalogId"].StringValue();

                string img_path = imageReader["img_path"].StringValue();

                var volume_dt = MyDBHelper.Query(string.Format(@"select * from domainvolume where isdelete = 0 and id = '{0}'", article.volumeid));

                if (volume_dt != null && volume_dt.Rows.Count == 1)
                {
                    article.contectcode = volume_dt.Rows[0]["contectCode"].StringValue();
                    article.name = volume_dt.Rows[0]["name"].StringValue();
                    article.year = volume_dt.Rows[0]["year"].StringValue();

                    string organization = volume_dt.Rows[0]["organization"].StringValue();
                    string organizationParent = volume_dt.Rows[0]["organizationParent"].StringValue();

                    OrganizationInfo oi = __getOrganizationInfo(organization);
                    OrganizationInfo oiParent = __getOrganizationInfo(organizationParent);

                    article.organizationcode = oi.Code;
                    article.organizationname = oi.Name;
                    article.parentorganizationcode = oiParent.Code;
                    article.parentorganizationname = oiParent.Name;
                }

                var content_dt = MyDBHelper.Query(string.Format(@"select * from domainArchiveContent where isdelete = 0 and id='{0}'", article.catalogid));
                if (content_dt != null && content_dt.Rows.Count == 1)
                {
                    article.responsibility = content_dt.Rows[0]["responsibility"].StringValue();
                    article.typenumber = content_dt.Rows[0]["typenumber"].StringValue();
                    article.subject = content_dt.Rows[0]["subject"].StringValue();
                }

                article.body = GetOCRText(article.imageid);

                yield return article;


            }
        }


        /// <summary>
        /// 获取指定imageId的信息，这里假定这些图片还没有进行过OCR识别
        /// </summary>
        /// <param name="imageIds"></param>
        /// <returns></returns>
        private IEnumerable<Article> GetRecords(IEnumerable<string> imageIds)
        {
            string sql = @"select * from domainCommentImage where id = '{0}'";

            foreach (string imageId in imageIds)
            {
                var imagedt = MyDBHelper.Query(string.Format(sql, imageId));
                if (imagedt == null || imagedt.Rows.Count != 1) continue;
                Article article = new Article();
                article.imageid = imageId;
                article.volumeid = imagedt.Rows[0]["attachId"].StringValue();
                article.catalogid = imagedt.Rows[0]["catalogId"].StringValue();

                string img_path = imagedt.Rows[0]["img_path"].StringValue();

                var volume_dt = MyDBHelper.Query(string.Format(@"select * from domainvolume where isdelete = 0 and id = '{0}'", article.volumeid));

                if (volume_dt != null && volume_dt.Rows.Count == 1)
                {
                    article.contectcode = volume_dt.Rows[0]["contectCode"].StringValue();
                    article.name = volume_dt.Rows[0]["name"].StringValue();
                    article.year = volume_dt.Rows[0]["year"].StringValue();

                    string organization = volume_dt.Rows[0]["organization"].StringValue();
                    string organizationParent = volume_dt.Rows[0]["organizationParent"].StringValue();

                    OrganizationInfo oi = __getOrganizationInfo(organization);
                    OrganizationInfo oiParent = __getOrganizationInfo(organizationParent);

                    article.organizationcode = oi.Code;
                    article.organizationname = oi.Name;
                    article.parentorganizationcode = oiParent.Code;
                    article.parentorganizationname = oiParent.Name;
                }

                var content_dt = MyDBHelper.Query(string.Format(@"select * from domainArchiveContent where isdelete = 0 and id='{0}'", article.catalogid));
                if (content_dt != null && content_dt.Rows.Count == 1)
                {
                    article.responsibility = content_dt.Rows[0]["responsibility"].StringValue();
                    article.typenumber = content_dt.Rows[0]["typenumber"].StringValue();
                    article.subject = content_dt.Rows[0]["subject"].StringValue();
                }

                article.body = GetOCRText(article.imageid);
                yield return article;
            }
        }


        private string GetOCRText(string imgid)
        {
            string cntsql = string.Format(@"select count(1) from domainOCRText where imageId = '{0}'", imgid);
            int count = (int)MyDBHelper.QueryScalar(cntsql, null);
            if (count > 0)
            {
                string sql = string.Format(@"select text from domainOCRText where imageId = '{0}'", imgid);
                return MyDBHelper.QueryScalar(sql, null).StringValue().Trim();
            }
            else
            {
                //没有OCR信息则启动OCR识别
                string pathsql = string.Format(@"select img_path from domainOCRText where imageId = '{0}'", imgid);
                string img_path = (string)MyDBHelper.QueryScalar(pathsql, null);
                string text = OCRHelper.OCRHelper.Execute(img_path);

                if (!string.IsNullOrEmpty(text))
                {
                    InsertOCR(imgid, text);
                    UpdateOCRStatus(imgid, true);
                }
                return text.Trim();
            }
        }

        private int InsertOCR(string imgId, string text)
        {
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

        private void UpdateOCRStatus(string imgId, bool indexed)
        {
            string uptsql = string.Format(@"update domainCommentImage set ocred='1' where imageid='{0}'", imgId);
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

            int rowsAffected = cmd.ExecuteNonQuery();

            string result = cmd.Parameters["@systemValue"].Value.ToString();
            return result;
        }



    }

    class OrganizationInfo
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
