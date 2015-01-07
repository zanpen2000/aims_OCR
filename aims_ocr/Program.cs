
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

using LuceneNetHelper;

namespace aims_ocr
{
    /*
     
       1、获取 imageId 和 imgPath
     * 2、OCR识别，返回 string并存入数据库（为了避免重新扫描）
     * 3、组织数据到Lucene.Net
     
     */


    class Program
    {


        static void Main(string[] args)
        {
            string cstring = Application.Layer.Tools.AppSettings.Get("ConnectionString");
            DBHelper.MyDBHelper.InitConnectionString(cstring);


            //var w = Writter.GetIndexWriter(true);
            //w.IndexCreateProgress += w_IndexCreateProgress;
            //int x = w.CreateIndex(new Data.DomainModel.LuceneNet.ArticleDetailDocument());
            //Console.WriteLine(x);
            //w.Optimize();
            //Writter.Close();

            Console.Write("请输入查询关键字：");
            string querystr = Console.ReadLine();

            Searcher searcher = new Searcher();
            searcher.SearchCompleted += searcher_SearchCompleted;

            var docs = searcher.Search<Article>(querystr, 1000);

            foreach (var doc in docs)
            {
                Console.WriteLine(string.Format("{0}:{1}", doc.imageid, doc.name));
            }

            Console.ReadKey();
        }

        private static void searcher_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {

            Console.WriteLine(e.Hits.ToString() + "  |  " + e.ElapsedMilliseconds.ToString());
            Console.WriteLine("search completed");
        }

        static void w_IndexCreateProgress(object sender, IndexCreateProgressEventArgs e)
        {
            Console.Write(".");
        }
    }
}
