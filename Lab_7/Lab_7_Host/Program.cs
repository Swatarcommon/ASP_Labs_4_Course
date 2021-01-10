using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_7;
using System.ServiceModel;

namespace Lab_7_Host
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(Lab_7.Feed1));
            host.Open();
            Console.WriteLine("Host Open");
            string s = Console.ReadLine();
        }
    }
}
