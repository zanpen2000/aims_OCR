using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{
    using Lucene.Net.Documents;

    /// <summary>
    /// 
    /// </summary>
    public interface IGetLuceneDocs
    {
        

        Documents GetDocuments(bool isCreate);

        Documents GetDocuments(IEnumerable<string> ids);
    }
}
