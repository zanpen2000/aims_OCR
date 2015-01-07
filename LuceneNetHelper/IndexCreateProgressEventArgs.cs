/*
 * Lucene.Net索引创建工具 -- 进度回调参数类
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
    /// <summary>
    /// 索引进度回调
    /// </summary>
    public class IndexCreateProgressEventArgs : EventArgs
    {
        /// <summary>
        /// 当前位置
        /// </summary>
        public int Position;

        /// <summary>
        /// 总数量
        /// </summary>
        public int Total;

        /// <summary>
        /// 百分比
        /// </summary>
        public int Percent { get { return Position * 100 / Total; } }

        public IndexCreateProgressEventArgs(int pos, int total)
        {
            this.Position = pos;
            this.Total = total;
        }
    }
}
