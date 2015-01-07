
using ExtensionsLib;
using LuceneNetHelper;
using Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace LuceneNetDemo
{
    public class MainViewModel : INotifyPropertyChanged
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
            set { reCreateIndex = value;
            OnPropertyChanged("ReCreateIndex");
            }
        }


        #endregion


        public EntityEventCommand SearchIndexCommand { get; set; }

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate { };

        public MainViewModel()
        {

            string cstring = AppSettings.Get("ConnectionString");
            DBHelper.MyDBHelper.InitConnectionString(cstring);
            this.Title = "Lucene.Net Demo";
            SearchIndexCommand = new EntityEventCommand(_searchIndexCommand);
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
            if (!Writter.IndexExists || ReCreateIndex)
            {
                var w = Writter.GetIndexWriter(true);
                w.IndexCreateProgress += w_IndexCreateProgress;
                int x = w.CreateIndex(new ArticleDetailDocument());
                w.Optimize();
                Writter.Close();
                this.Title = this.Title.Split('-')[0] + " - " + x.ToString();
                ReCreateIndex = false;
            }

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
    }
}
