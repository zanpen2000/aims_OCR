/*
   将sysKeywordsDTO表中的数据批量插入到盘古分词词库
 * 
 * 张鹏
 * 2014/3/4
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PanGuHelper
{

      using ExtensionsLib;
      using System.IO;

      /// <summary>
      /// 批量插入到盘古分词词库
      /// </summary>
      public class Keywords2dict
      {
            PanguDictManager pdm = new PanguDictManager();

            /// <summary>
            /// 词汇数量
            /// </summary>
            int _totalWords;
            public int TotalWords { get { return _totalWords; } }

            public Keywords2dict(string dictfilename)
            {
                  //Load字典
                  _totalWords = pdm.Load(dictfilename);
            }

            public static string GetDictPath()
            {
                  string path = AppDomain.CurrentDomain.BaseDirectory + "bin\\PanGu.xml";
                  PanGu.Setting.PanGuSettings.Load(path);
                  return AppDomain.CurrentDomain.BaseDirectory + "bin\\" + PanGu.Setting.PanGuSettings.Config.DictionaryPath + "\\dict.dct";
            }

            /// <summary>
            /// 批量插入
            /// </summary>
            /// <param name="words"></param>
            /// <returns></returns>
            public bool BatchInsert(IEnumerable<UserWords> words)
            {
                  words.ForEach(t =>
                  {
                        pdm.Insert(t.Name);
                  });
                  return pdm.Save();
            }

            public bool BatchInsert(IList<string> strWords)
            {
                  strWords.ForEach(w =>
                  {
                        pdm.Insert(w, 0.0, (PanGu.POS)Enum.Parse(typeof(PanGu.POS), "0"));
                  });
                  return pdm.Save();
            }

            public bool Insert(UserWords t)
            {
                  pdm.Insert(t.Name);
                  return pdm.Save();
            }

       
      }
}
