using LuceneNetHelper;
using System.Linq;
using System.ServiceModel;

namespace SearchService
{
    [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class TextSearch : SearchContract.ITextSearch
    {

        public void Search(string keywords)
        {
            __buildIndex(false);

            if (string.IsNullOrEmpty(keywords)) return;

            Searcher searcher = new Searcher();
            var lst = searcher.MultiKeyWordSearch<Article>(keywords, 1000);

            var cb = OperationContext.Current.GetCallbackChannel<SearchContract.ISearchCallback>();
            cb.ReturnSearchResult(from n in lst select n.imageid);
        }

        private static int __buildIndex(bool recreate)
        {
            
            bool mustcreate = false;
            if (recreate || !Writter.IndexExists) mustcreate = true;
            var w = Writter.GetIndexWriter(mustcreate);
            int idx_count = w.CreateIndex(new ArticleDetailDocument());
            w.Optimize();
            Writter.Close();
            return idx_count;
        }


        public void ReIndex()
        {
            var idxCount = __buildIndex(true);
            var cb = OperationContext.Current.GetCallbackChannel<SearchContract.ISearchCallback>();
            cb.ReturnReIndexResult(idxCount.ToString());
        }
    }
}
