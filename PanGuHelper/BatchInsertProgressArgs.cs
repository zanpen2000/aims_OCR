using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PanGuHelper
{
    /// <summary>
    /// 批量添加事件参数
    /// </summary>
    public class BatchInsertProgressArgs : EventArgs
    {
        public float Percent;
        public int ErrorCount;
        public int SuccessCount;
        public int TotalCount;
    }
}
