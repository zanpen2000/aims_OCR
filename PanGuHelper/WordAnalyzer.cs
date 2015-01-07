using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionsLib;

namespace PanGuHelper
{

    /// <summary>
    /// 盘古分词扩展接口
    /// 作者：张鹏
    /// 日期：2014/2/27
    /// </summary>
    public class WordAnalyzer
    {
        /// <summary>
        /// 盘古分词
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static IEnumerable<PanGu.WordInfo> TokeniseWordInfo(string text)
        {
            return (from word in new Lucene.Net.Analysis.PanGu.PanGuTokenizer().SegmentToWordInfos(text)
                    //去掉单字
                    where word.Word.Length > 1
                    select word).ToList();
        }

        /// <summary>
        /// 计算给定的分词序列中单词的词频
        /// </summary>
        /// <param name="words"></param>
        /// <returns></returns>
        public static IEnumerable<WordFreq> Frequency(IEnumerable<PanGu.WordInfo> words)
        {
            Hashtable ht = new Hashtable();
            List<WordFreq> lst = new List<WordFreq>();

            words.ForEach((t) =>
            {
                ht[t.Word] = ht.ContainsKey(t.Word) ? Convert.ToInt32(ht[t.Word]) + 1 : 1;
            });

            var iter = ht.GetEnumerator();
            while (iter.MoveNext())
            {
                lst.Add(new WordFreq()
                {
                    Word = iter.Key.ToString(),
                    Freq = Convert.ToInt32(iter.Value)
                });
            }
            return lst;
        }

        /// <summary>
        /// 计算、统计词频
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static IEnumerable<WordFreq> Frequency(string text)
        {
            Hashtable ht = new Hashtable();

            List<WordFreq> lst = new List<WordFreq>();

            TokeniseWordInfo(text).ForEach((t) =>
            {
                ht[t.Word] = ht.ContainsKey(t.Word) ? Convert.ToInt32(ht[t.Word]) + 1 : 1;
            });

            var iter = ht.GetEnumerator();
            while (iter.MoveNext())
            {
                lst.Add(new WordFreq()
                {
                    Word = iter.Key.ToString(),
                    Freq = Convert.ToInt32(iter.Value)
                });
            }
            return lst;
        }

        /// <summary>
        /// 返回给定文本中指定词汇的词频
        /// </summary>
        /// <param name="text"></param>
        /// <param name="word"></param>
        /// <returns>词频</returns>
        public static int Frequency(string text, string word)
        {
            return (from n in Frequency(text) where n.Word == word select n).First().Freq;
        }
    }
}
