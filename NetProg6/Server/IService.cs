using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract(IsOneWay = true)]
        void HelloUser (string name);

        [OperationContract]
        int Summator(int num1, int num2);
    }
}
