using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Uri baseAddress = new Uri("http://localhost:8080/cassService");
            try
            {
                using (ServiceHost host = new ServiceHost(typeof(Service), baseAddress))
                {
                    ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
                    smb.HttpGetEnabled = true;
                    smb.MetadataExporter.PolicyVersion = PolicyVersion.Policy15;
                    host.Description.Behaviors.Add(smb);
                    host.Open();
                    Console.WriteLine("Сервер стартовал успешно");
                    Console.ReadLine();
                }
            }
            catch
            {
                Console.WriteLine("Возникла ошибка при старте сервера. Убедитесь, что производите запуск с правами администратора");
                Console.ReadLine();
            }
        }
    }
}
