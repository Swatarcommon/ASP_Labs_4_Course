using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using WebServices.Example1;

namespace Lab_4_WebForm {
    public class SimpleClass : ISimpleSoap {
        public int Add(int x, int y) {
            return x + y;
        }

        public int Adds(int x, int y) {
            return x + y;
        }

        public string Concat(string s, double d) {
            return s + d;
        }

        public A Sum(A a1, A a2) {
            return new A(a1.s + a2.s, a1.k + a2.k, a1.f + a2.f);
        }
    }
}