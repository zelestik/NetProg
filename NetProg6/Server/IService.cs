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
        [OperationContract]
        bool AddCard(long cardNum);

        [OperationContract]
        long GetBalance(long cardNum);

        [OperationContract]
        long ChangeCardBalance(long cardNum, long moneyToAdd);
    }
}
