using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OCRHelper
{
    public class OCRProcessingEventArgs : EventArgs
    {

        public string ImageId { get; set; }
        public string Text { get; set; }

        public OCRProcessingEventArgs(string imgid, string text)
        {
            this.ImageId = imgid;
            this.Text = text;
        }
    }
}
