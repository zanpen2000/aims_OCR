using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SearchContract
{
    public interface ISearchCallback
    {
        [OperationContract(IsOneWay = true)]
        void ReturnSearchResult(IEnumerable<string> imageIds);

        [OperationContract(IsOneWay = true)]
        void ReturnReIndexResult(string msg);
    }
}
