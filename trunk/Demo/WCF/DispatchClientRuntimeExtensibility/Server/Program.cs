using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a server");
            ServiceHost serviceHost = new ServiceHost(typeof(Calculator));
            try
            {
                Console.WriteLine("Service is initialized and running");
                serviceHost.Open();
                Console.WriteLine("The 'Calculator' service is up and running.");
                Console.WriteLine("Press 'Enter' to exit the application");
                Console.ReadLine();
                serviceHost.Close();
                Console.WriteLine("Service shutdown properly");
            }
            catch (Exception ex)
            {
                Console.WriteLine("There is a problem in service {0}", ex.Message);
                serviceHost.Abort();
            }
            
        }
    }
}
