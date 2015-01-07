
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuceneNetHelper.Attributes
{
    using System.Data;
    using Lucene.Net.Documents;

    public class FieldAttribute : System.Attribute
    {
        public string Name { set; get; }
        public Field.Store Store { set; get; }
        public Field.Index Index { set; get; }


        public FieldAttribute(string name, Field.Store store,Field.Index index)
        {
            this.Name = name;
            this.Store = store;
            this.Index = index;
        }

        public FieldAttribute(string name) : this(name, Field.Store.YES, Field.Index.ANALYZED) { }

        public FieldAttribute() : this(null, Field.Store.YES, Field.Index.ANALYZED) { }


    }
}
