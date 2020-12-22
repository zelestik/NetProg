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
        public void HelloUser(string UserName)
        {
            Console.WriteLine("Привет" + UserName);
        }

        public int Summator(int num1, int num2)
        {
            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            return num1 + num2;
        }
    }
}
