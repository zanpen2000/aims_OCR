/*
 * Lucene.Net索引创建工具
 * 
   作者：张鹏
 * 日期：2014/3/13
 
 * 注意事项：
 * 
 * 1、并发情况下请使用IndexWriter的单一实例，否则会报锁异常
 * 2、创建索引之后，关闭索引之前，不会进行真正的索引，只有执行Dispose方法后索引才会生效
 * 3、关于进一步优化，使用上的细节，欢迎补充源码，尽量不要修改本代码，如有修改，务必添加详细的注释说明。谢谢！
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{
    using Lucene.Net.Analysis;
    using Lucene.Net.Index;
    using Lucene.Net.Analysis.PanGu;

    /// <summary>
    /// 索引创建工具
    /// </summary>
    public class Writter : IDisposable
    {
        /// <summary>
        /// 创建索引进度回调
        /// </summary>
        public event EventHandler<IndexCreateProgressEventArgs> IndexCreateProgress = delegate { };

        /// <summary>
        /// 分词器
        /// </summary>
        public static Lucene.Net.Analysis.PanGu.PanGuAnalyzer analyzer = new PanGuAnalyzer();

        /// <summary>
        /// 目录
        /// </summary>
        public static Lucene.Net.Store.Directory Directory = consts.FSDirectory;


        public static bool IndexExists { get { return System.IO.Directory.Exists(consts.FSDirectory.Directory.FullName); } }

        /// <summary>
        /// 单例实现
        /// </summary>
        /// <param name="isCreate"></param>
        /// <returns></returns>
        public static Writter GetIndexWriter(bool isCreate)
        {
            if (_writter == null)
            {
                lock (obj)
                {
                    if (_writter == null)
                    {
                        _writter = new Writter(isCreate);
                    }
                }
            }
            return _writter;
        }

        static object obj = new object();

        static Writter _writter;

        IndexWriter indexWriter = null;

        private bool IsCreate;

        private Writter(bool isCreate = false)
        {
            this.IsCreate = isCreate;
            if (isCreate)
            {
                _eraseIndex();
            }

            PanGu.Segment.Init();

            indexWriter = new IndexWriter(
                Directory,
                analyzer,
                isCreate,
                IndexWriter.MaxFieldLength.UNLIMITED);
        }

        private void _eraseIndex()
        {
            System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(consts.FSDirectory.Directory.FullName);

            if (di.Exists)
            {
                di.Delete(true);
            }
        }

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="docs">文档集合</param>
        /// <returns>索引记录数量</returns>
        public int CreateIndex(Documents docs)
        {
            Documents documents = docs;
            int total = documents.Count(), i = 0;

            foreach (var doc in documents)
            {
                indexWriter.AddDocument(doc);
                OnIndexCreateProgress(this, new IndexCreateProgressEventArgs(++i, total));
            }

            return indexWriter.NumDocs();
        }


        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="docs">实现IGetLuceneDocs接口的对象实例</param>
        /// <returns>索引记录数量</returns>
        public int CreateIndex(IGetLuceneDocs docs)
        {
            Documents documents = docs.GetDocuments(IsCreate);
            return this.CreateIndex(documents);
        }

        /// <summary>
        /// 创建索引
        /// </summary>
        /// <param name="ids">文章的ID列表</param>
        /// <returns>索引记录数量</returns>
        public int CreateIndex(List<string> ids)
        {
            var x = new ArticleDetailDocument();

            var n = this.CreateIndex(x.GetDocuments(ids));

            Optimize();

            return n;
        }


        /// <summary>
        /// 进度回调
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="arg"></param>
        public void OnIndexCreateProgress(object sender, IndexCreateProgressEventArgs arg)
        {
            IndexCreateProgress(sender, arg);
        }

        /// <summary>
        /// 确保释放
        /// </summary>
        public void Dispose()
        {
            indexWriter.Dispose();
        }

        /// <summary>
        /// 释放并使索引可用
        /// </summary>
        public static void Close()
        {
            if (_writter != null)
            {
                lock (obj)
                {
                    if (_writter != null)
                    {
                        _writter.Dispose();
                        _writter = null;
                    }
                }
            }
        }

        /// <summary>
        /// 合并碎片
        /// </summary>
        public void Optimize()
        {
            if (_writter != null)
            {
                lock (obj)
                {
                    if (_writter != null)
                    {
                        indexWriter.Optimize();
                    }
                }
            }
            
        }
    }
}
