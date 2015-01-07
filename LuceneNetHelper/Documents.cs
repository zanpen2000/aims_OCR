/*
 *Lucene.Net Document 装饰类，返回一个 Lucene.Net Document 的枚举器以供IndexWriter创建文档索引
 * 
 * 张鹏 2014/3/13
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{
    /// <summary>
    /// Lucene.Net Document 装饰类，返回一个 Lucene.Net Document 的枚举器以供IndexWriter创建文档索引
    /// </summary>
    public class Documents : IEnumerable<Lucene.Net.Documents.Document>
    {
        private List<Lucene.Net.Documents.Document> _docList = null;

        public Documents()
        {
            _docList = new List<Lucene.Net.Documents.Document>();
        }

        public void Add(Lucene.Net.Documents.Document doc)
        {
            _docList.Add(doc);
        }

        public IEnumerator<Lucene.Net.Documents.Document> GetEnumerator()
        {
            return this._docList.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this._docList.GetEnumerator();
        }
    }
}
