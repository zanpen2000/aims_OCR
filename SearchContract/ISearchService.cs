using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;

namespace SearchContract
{
    
    [ServiceContract(CallbackContract=typeof(ISearchCallback))]
    public interface ITextSearch
    {
        [OperationContract(IsOneWay=true)]
        void Search(string keywords);

        [OperationContract(IsOneWay = true)]
        void ReIndex();
    }
}
