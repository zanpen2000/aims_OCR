using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{

    /// <summary>
    /// 元数据
    /// </summary>
    internal class consts
    {
        public static Lucene.Net.Store.FSDirectory FSDirectory = Lucene.Net.Store.FSDirectory.Open("/index");
        public static Lucene.Net.Store.RAMDirectory RAMDirectory = new Lucene.Net.Store.RAMDirectory();
    }
}
