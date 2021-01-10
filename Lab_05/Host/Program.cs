using System;
using System.ServiceModel;
using WCF;

namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new ServiceHost(typeof(Simplex));
            host.Open();
            Console.WriteLine("Service has been started");
            Console.ReadLine();
        }
    }
}
