using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Server
{

    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class Service : IService
    {
        DB db = new DB();
        public bool AddCard(long cardNum)
        {
            return db.AddCard(cardNum);
        }

        public long ChangeCardBalance(long cardNum, long moneyToAdd)
        {
            if (db.ChangeBalance(cardNum, moneyToAdd))
                return db.getBalance(cardNum);
            else
                return long.MinValue;
        }

        public long GetBalance(long cardNum)
        {
            return db.getBalance(cardNum);
        }
    }
}
