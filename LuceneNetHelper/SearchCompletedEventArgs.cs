using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper
{
    /// <summary>
    /// 搜索完成事件参数
    /// </summary>
    public class SearchCompletedEventArgs:EventArgs
    {
        /// <summary>
        /// 搜索命中数量
        /// </summary>
        public int Hits { get; set; }

        /// <summary>
        /// 花费的时间（毫秒）
        /// </summary>
        public long ElapsedMilliseconds { get; set; }
    }
}
