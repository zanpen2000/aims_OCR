using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace LuceneNetHelper
{

    using ExtensionsLib;
    using Attributes;
    /// <summary>
    /// 业务对象，由于是使用反射做处理，必须与数据库字段名称保持一致
    /// 
    /// </summary>
    [Document]
    public class Article
    {
        public string this[string fieldName]
        {
            get
            {
                PropertyInfo[] ps = this.GetType().GetProperties();

                string result = string.Empty;

                foreach (var p in ps)
                {
                    if (p.Name.ToLower().Equals(fieldName))
                    {
                        result = p.GetValue(this, null).StringValue();
                        break;
                    }
                }
                return result;
            }
        }

        /// <summary>
        /// 图片id
        /// </summary>
        [Field("imageid", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.YES)]
        public string imageid { get; set; }

        /// <summary>
        /// 目录id
        /// </summary>
        [Field("catalogid", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.YES)]
        public string catalogid { get; set; }

        /// <summary>
        /// 案卷id（流水号）
        /// </summary>
        [Field("volumeid", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.YES)]
        public string volumeid { get; set; }

        /// <summary>
        /// 案卷号
        /// </summary>
        [Field("contectcode", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string contectcode { get; set; }

        /// <summary>
        /// 案卷名称
        /// </summary>
        [Field("name", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string name { get; set; }

        /// <summary>
        /// 主题（目录名）
        /// </summary>
        [Field("subject", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string subject { get; set; }

        /// <summary>
        /// 责任者
        /// </summary>
        [Field("responsibility", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string responsibility { get; set; }

        /// <summary>
        /// 文号
        /// </summary>
        [Field("typenumber", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string typenumber { get; set; }

        /// <summary>
        /// 正文
        /// </summary>
        [Field("body", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string body { get; set; }


        /// <summary>
        /// 年份
        /// </summary>
        [Field("year", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string year { get; set; }

        /// <summary>
        /// 机构分类代码
        /// </summary>
        [Field("organizationcode", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string organizationcode { get; set; }

        /// <summary>
        /// 机构分类名称
        /// </summary>
        [Field("organizationname", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string organizationname { get; set; }

        /// <summary>
        /// 机构分类代码(父)
        /// </summary>
        [Field("parentorganizationcode", Index = Lucene.Net.Documents.Field.Index.NOT_ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string parentorganizationcode { get; set; }

        /// <summary>
        /// 机构分类名称（父）
        /// </summary>
        [Field("parentorganizationname", Index = Lucene.Net.Documents.Field.Index.ANALYZED, Store = Lucene.Net.Documents.Field.Store.NO)]
        public string parentorganizationname { get; set; }

       
    }
}
