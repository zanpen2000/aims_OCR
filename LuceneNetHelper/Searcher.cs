/*
  * Lucene.Net搜索器
 * 
   作者：张鹏
 * 日期：2014/3/13
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{
    using Lucene.Net.Documents;
    using Lucene.Net.Search;
    using Lucene.Net.Store;
    using System.Reflection;

    using ExtensionsLib;
    using System.Diagnostics;
    using Lucene.Net.QueryParsers;
    using PanGu.HighLight;
    using Attributes;

    /// <summary>
    /// Lucene.Net搜索
    /// </summary>
    public class Searcher
    {
        /// <summary>
        /// 搜索完成事件
        /// </summary>
        public event EventHandler<SearchCompletedEventArgs> SearchCompleted = delegate { };

        /// <summary>
        /// 搜索器
        /// </summary>
        IndexSearcher _searcher = null;

        public Searcher()
        {
            _searcher = new IndexSearcher(Writter.Directory);
        }

        bool _shouldNumberAnalyzer(string k)
        {
            return k.All(x => "0123456789".IndexOf(x) != -1);
        }


        /// <summary>
        /// 多关键字查询
        /// </summary>
        /// <typeparam name="TSearchResult"></typeparam>
        /// <param name="text"></param>
        /// <param name="topHits"></param>
        /// <returns></returns>
        public IEnumerable<TSearchResult> MultiKeyWordSearch<TSearchResult>(string text, int topHits = 10)
        {
            var keys = text.Split(new char[] { ' ', ',', '，' }, StringSplitOptions.RemoveEmptyEntries);
            Type resultElementType = typeof(TSearchResult);
            var fieldmaps = this.getDocumentFields(resultElementType);
            string[] fields = fieldmaps.Values.ToArray();

            Lucene.Net.Search.BooleanQuery booleanQuery = new Lucene.Net.Search.BooleanQuery();

            for (int i = 0; i < keys.Length; i++)
            {
                string word = keys[i];
                Lucene.Net.Analysis.Analyzer analyzer = null;
                if (_shouldNumberAnalyzer(word))
                    analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
                else
                    analyzer = Writter.analyzer;
                QueryParser parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, fields, analyzer);
                //parser.DefaultOperator = QueryParser.Operator.OR;
                Lucene.Net.Search.Query query = parser.Parse(word);
                booleanQuery.Add(query, Occur.MUST);
            }

            Stopwatch stopwatch = Stopwatch.StartNew();
            TopDocs docs = _searcher.Search(booleanQuery, topHits);
            stopwatch.Stop();

            OnSearchCompleted(this, new SearchCompletedEventArgs() { Hits = docs.TotalHits, ElapsedMilliseconds = stopwatch.ElapsedMilliseconds });

            List<TSearchResult> tlst = new List<TSearchResult>(topHits);

            for (int i = 0; i < (topHits > docs.TotalHits ? docs.TotalHits : topHits); i++)
            {
                var documentItem = _searcher.Doc(docs.ScoreDocs[i].Doc);

                TSearchResult resultObjectItem = (TSearchResult)Activator.CreateInstance(resultElementType);

                string fieldName = string.Empty;

                foreach (PropertyInfo resultObjectProperty in resultElementType.GetProperties())
                {
                    if (fieldmaps.TryGetValue(resultObjectProperty.Name, out fieldName))
                    {
                        if (!string.IsNullOrEmpty(fieldName))
                        {
                            string propertyValue = documentItem.Get(fieldName);
                            resultObjectProperty.SetValue(resultObjectItem, propertyValue.StringValue(), null);
                        }
                    }
                    else
                    {
                        string propertyValue = documentItem.Get(resultObjectProperty.Name);
                        if (!string.IsNullOrEmpty(propertyValue))
                        {
                            resultObjectProperty.SetValue(resultObjectItem, propertyValue.StringValue(), null);
                        }

                    }
                }
                tlst.Add(resultObjectItem);
            }

            return tlst;
        }


        public IEnumerable<TSearchResult> PrefixSearch<TSearchResult>(string text, int topHits = 10)
        {
            if (string.IsNullOrEmpty(text)) return null;

            Type resultElementType = typeof(TSearchResult);
            var fieldmaps = this.getDocumentFields(resultElementType);
            string[] fields = fieldmaps.Values.ToArray();

            Lucene.Net.Analysis.Analyzer analyzer = null;

            if (_shouldNumberAnalyzer(text))
                analyzer = new Lucene.Net.Analysis.Standard.StandardAnalyzer(Lucene.Net.Util.Version.LUCENE_30);
            else
                analyzer = Writter.analyzer;

            MultiFieldQueryParser parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, fields,
                analyzer
                );
            var query = parser.Parse(text);
            Stopwatch stopwatch = Stopwatch.StartNew();
            TopDocs docs = _searcher.Search(query, topHits);
            stopwatch.Stop();

            OnSearchCompleted(this, new SearchCompletedEventArgs() { Hits = docs.TotalHits, ElapsedMilliseconds = stopwatch.ElapsedMilliseconds });

            List<TSearchResult> tlst = new List<TSearchResult>(topHits);

            for (int i = 0; i < (topHits > docs.TotalHits ? docs.TotalHits : topHits); i++)
            {
                var documentItem = _searcher.Doc(docs.ScoreDocs[i].Doc);

                TSearchResult resultObjectItem = (TSearchResult)Activator.CreateInstance(resultElementType);

                string fieldName = string.Empty;

                foreach (PropertyInfo resultObjectProperty in resultElementType.GetProperties())
                {
                    if (fieldmaps.TryGetValue(resultObjectProperty.Name, out fieldName))
                    {
                        if (!string.IsNullOrEmpty(fieldName))
                        {
                            string propertyValue = documentItem.Get(fieldName);
                            resultObjectProperty.SetValue(resultObjectItem, propertyValue.StringValue(), null);
                        }
                    }
                    else
                    {
                        string propertyValue = documentItem.Get(resultObjectProperty.Name);
                        if (!string.IsNullOrEmpty(propertyValue))
                        {
                            resultObjectProperty.SetValue(resultObjectItem, propertyValue.StringValue(), null);
                        }

                    }
                }
                tlst.Add(resultObjectItem);
            }

            return tlst;
        }


        /// <summary>
        /// 搜索
        /// </summary>
        /// <typeparam name="TSearchResult"></typeparam>
        /// <param name="field"></param>
        /// <param name="text"></param>
        /// <param name="topHits"></param>
        /// <returns></returns>
        public IEnumerable<TSearchResult> Search<TSearchResult>(string text, int topHits = 10)
        {
            if (string.IsNullOrEmpty(text)) return null;
            Type resultElementType = typeof(TSearchResult);

            var fieldmaps = this.getDocumentFields(resultElementType);

            string[] fields = fieldmaps.Values.ToArray();

            QueryParser parser = new MultiFieldQueryParser(Lucene.Net.Util.Version.LUCENE_30, fields, Writter.analyzer);
            parser.DefaultOperator = QueryParser.Operator.OR;
            Lucene.Net.Search.BooleanQuery booleanQuery = new Lucene.Net.Search.BooleanQuery();
            Lucene.Net.Search.Query tempQuery = parser.Parse(text);
            booleanQuery.Add(tempQuery, Occur.MUST);

            Stopwatch stopwatch = Stopwatch.StartNew();
            TopDocs docs = _searcher.Search(booleanQuery, topHits);
            stopwatch.Stop();

            OnSearchCompleted(this, new SearchCompletedEventArgs() { Hits = docs.TotalHits, ElapsedMilliseconds = stopwatch.ElapsedMilliseconds });

            List<TSearchResult> tlst = new List<TSearchResult>(topHits);

            for (int i = 0; i < (topHits > docs.TotalHits ? docs.TotalHits : topHits); i++)
            {
                var documentItem = _searcher.Doc(docs.ScoreDocs[i].Doc);

                TSearchResult resultObjectItem = (TSearchResult)Activator.CreateInstance(resultElementType);

                string fieldName = string.Empty;

                foreach (PropertyInfo resultObjectProperty in resultElementType.GetProperties())
                {
                    if (fieldmaps.TryGetValue(resultObjectProperty.Name, out fieldName))
                    {
                        if (!string.IsNullOrEmpty(fieldName))
                        {
                            string propertyValue = documentItem.Get(fieldName);
                            resultObjectProperty.SetValue(resultObjectItem, propertyValue.StringValue(), null);
                        }
                    }
                    else
                    {
                        string propertyValue = documentItem.Get(resultObjectProperty.Name);
                        if (!string.IsNullOrEmpty(propertyValue))
                        {
                            resultObjectProperty.SetValue(resultObjectItem, propertyValue.StringValue(), null);
                        }

                    }
                }
                tlst.Add(resultObjectItem);
                //tlst.Add(SetHighlighter<TSearchResult>(text, resultObjectItem));
            }

            return tlst;
        }

        /// <summary>
        /// return list as  property name and field name 
        /// </summary>
        /// <param name="TSearchResultType"></param>
        /// <returns></returns>
        private Dictionary<string, string> getDocumentFields(Type TSearchResultType)
        {
            if (TSearchResultType.GetCustomAttributes(typeof(DocumentAttribute), false).Length <= 0)
                throw new InvalidOperationException("搜索对象没有定义Document特性！");

            Dictionary<string, string> fieldList = new Dictionary<string, string>();

            foreach (PropertyInfo property in TSearchResultType.GetProperties())
            {
                var attributes = property.GetCustomAttributes(typeof(FieldAttribute), false);

                if (attributes.Length > 0)
                {
                    var fieldInfo = attributes[0] as FieldAttribute;

                    if (fieldInfo.Index != Field.Index.NO)
                        fieldList.Add(property.Name, fieldInfo.Name);


                    //if (fieldInfo.Store == Field.Store.YES && fieldInfo.Index != Field.Index.NO)
                    //    fieldList.Add(property.Name, fieldInfo.Name);
                }

            }

            if (fieldList.Count > 0)
                return fieldList;

            throw new InvalidOperationException("搜索对象没有定义Field特性！");

        }

        public static TSearchResult SetHighlighter<TSearchResult>(string keyword, TSearchResult model)
        {
            SimpleHTMLFormatter simpleHTMLFormatter = new PanGu.HighLight.SimpleHTMLFormatter("<font color=\"green\">", "</font>");
            Highlighter highlighter = new PanGu.HighLight.Highlighter(simpleHTMLFormatter, new PanGu.Segment());
            highlighter.FragmentSize = int.MaxValue;

            Type resultElementType = typeof(TSearchResult);
            foreach (PropertyInfo resultObjectProperty in resultElementType.GetProperties())
            {
                var value = resultObjectProperty.GetValue(model, null).StringValue();

                var render = highlighter.GetFragments(keyword, value, int.MaxValue);

                StringBuilder builder = new StringBuilder();

                if (render.Count() > 0) render.ForEach(t => builder.Append(t));

                string r = builder.ToString();

                if (string.IsNullOrEmpty(r)) r = value;

                resultObjectProperty.SetValue(model, r, null);
            }
            return model;
        }

        public void OnSearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            SearchCompleted(sender, e);
        }
    }
}
