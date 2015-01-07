using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper.Attributes
{
    public class DocumentAttribute : System.Attribute
    {
        public string Name { set; get; }

        public DocumentAttribute(string name) {
            this.Name = name;
        }

        public DocumentAttribute()
        {

        }


    }
}
