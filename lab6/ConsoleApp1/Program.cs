using SyndicationServiceLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Feed1));
            host.Open();
            Console.WriteLine("Host Open");
            string s = Console.ReadLine();
        }
    }
}
