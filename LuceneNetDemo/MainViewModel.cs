
using ExtensionsLib;
using LuceneNetHelper;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace LuceneNetDemo
{
    public class MainViewModel : INotifyPropertyChanged, SearchContract.ISearchCallback
    {
        #region Propertys

        private string searchStr;

        public string SearchStr
        {
            get { return searchStr; }
            set
            {
                searchStr = value;
                OnPropertyChanged("SearchStr");
            }
        }

        private int progressvalue;

        public int ProgressValue
        {
            get { return progressvalue; ; }
            set
            {
                progressvalue = value;
                OnPropertyChanged("progressvalue");
            }
        }


        private bool progressing;

        public bool Progressing
        {
            get { return progressing; }
            set
            {
                progressing = value;
                OnPropertyChanged("progressing");
            }
        }

        private ObservableCollection<Article> articles;

        public ObservableCollection<Article> Articles
        {
            get { return articles; }
            set
            {
                articles = value;
                OnPropertyChanged("articles");
            }
        }

        private string title;

        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                OnPropertyChanged("Title");
            }
        }


        private ObservableCollection<LogItem> logItems;

        public ObservableCollection<LogItem> LogItems
        {
            get { return logItems; }
            set
            {
                logItems = value;
                OnPropertyChanged("LogItems");
            }
        }


        private bool reCreateIndex;

        public bool ReCreateIndex
        {
            get { return reCreateIndex; }
            set
            {
                reCreateIndex = value;
                OnPropertyChanged("ReCreateIndex");
            }
        }


        #endregion


        public EntityEventCommand SearchIndexCommand { get; set; }
        public EntityEventCommand SearchWcfCommand { get; set; }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainViewModel()
        {
            DBHelper.MyDBHelper.InitConnectionString();
            this.Title = "Lucene.Net Demo";
            SearchIndexCommand = new EntityEventCommand(_searchIndexCommand);
            SearchWcfCommand = new EntityEventCommand(_searchWcfCommand);
        }



        private void _searchIndexCommand()
        {
            Progressing = true;
            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += bw_DoWork;
            bw.RunWorkerCompleted += bw_RunWorkerCompleted;
            bw.RunWorkerAsync();
        }

        void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Progressing = false;
        }

        void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            bool recreate = false;

            recreate = Writter.IndexExists ? ReCreateIndex : true;

            if (Writter.IndexExists)
            {
                recreate = ReCreateIndex;
            }

            var w = Writter.GetIndexWriter(recreate);
            w.IndexCreateProgress += w_IndexCreateProgress;
            int x = w.CreateIndex(new ArticleDetailDocument());
            w.Optimize();
            Writter.Close();
            this.Title = this.Title.Split('-')[0] + " - " + x.ToString();
            ReCreateIndex = false;

            if (string.IsNullOrEmpty(SearchStr))
                return;

            Searcher searcher = new Searcher();
            searcher.SearchCompleted += searcher_SearchCompleted;

            Articles = new ObservableCollection<Article>(searcher.MultiKeyWordSearch<Article>(SearchStr, 1000));

        }

        private void searcher_SearchCompleted(object sender, SearchCompletedEventArgs e)
        {
            LogItems = new ObservableCollection<LogItem>();
            LogItems.Add(new LogItem()
            {
                time = DateTime.Now.ToString(),
                msg = string.Format("命中：{0}, 耗时：{1}毫秒",
                    e.Hits.ToString(), e.ElapsedMilliseconds.ToString())
            });
        }

        private void w_IndexCreateProgress(object sender, IndexCreateProgressEventArgs e)
        {
            ProgressValue = e.Percent;
            Progressing = e.Percent != 100;
        }

        public void ReturnSearchResult(IEnumerable<string> imageIds)
        {
            Title = " 结果数量: " + imageIds.Count().ToString();
        }

        public void ReturnReIndexResult(string msg)
        {
            //throw new NotImplementedException();
            Title = msg;
        }

        private void _searchWcfCommand()
        {
            if (string.IsNullOrEmpty(SearchStr)) return;
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                NetTcpBinding theBinding = __getTcpBinding();
                InstanceContext context = new InstanceContext(this);
                var channel = new DuplexChannelFactory<SearchContract.ITextSearch>(context, new NetTcpBinding(),
                    new EndpointAddress("net.tcp://localhost:8006/TextSearch.svc")
                    );
                SearchContract.ITextSearch proxy = channel.CreateChannel();
                proxy.Search(SearchStr);
            });
        }

        private static NetTcpBinding __getTcpBinding()
        {
            NetTcpBinding theBinding = new NetTcpBinding();
            theBinding.MaxReceivedMessageSize = int.MaxValue;
            theBinding.MaxBufferSize = int.MaxValue;
            theBinding.MaxBufferPoolSize = int.MaxValue;
            theBinding.ReaderQuotas.MaxDepth = 32;
            theBinding.ReaderQuotas.MaxStringContentLength = 2147483647;
            theBinding.ReaderQuotas.MaxArrayLength = 2147483647;
            theBinding.ReaderQuotas.MaxBytesPerRead = 4096;
            theBinding.ReaderQuotas.MaxNameTableCharCount = 2147483647;
            theBinding.Security.Mode = SecurityMode.None;
            theBinding.TransferMode = TransferMode.Buffered;
            theBinding.TransactionProtocol = TransactionProtocol.OleTransactions;
            theBinding.HostNameComparisonMode = HostNameComparisonMode.StrongWildcard;
            theBinding.MaxConnections = 10;
            theBinding.TransactionFlow = false;
            theBinding.CloseTimeout = TimeSpan.MaxValue;
            theBinding.SendTimeout = TimeSpan.MaxValue;

            return theBinding;
        }
    }
}
