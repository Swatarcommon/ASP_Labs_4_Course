﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            string binding = "BasicHttpBinding_ISimplex";
            //string binding = "tcpEndpoint";
            WCF.SimplexClient simpleClient = new WCF.SimplexClient(binding);
            Console.WriteLine("Method add for int and int: " + simpleClient.Add(1, 3));
            Console.WriteLine("Method concat for str and double: " + simpleClient.Concat("str", 3));
            WCF.A a = simpleClient.Sum(new WCF.A { f = 3.2f, k = 1, s = "4" }, new WCF.A { f = 1.3f, k = 2, s = "12" });
            Console.WriteLine($"Result of sum object: f = {a.f} k = {a.k} s = {a.s}");
            simpleClient.Close();
        }
    }
}
