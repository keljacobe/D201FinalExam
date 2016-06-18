using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D201FinalExam
{
    class ClassA
    {
        string n;
        string o;
        string b;
        int a;

        public string N
        {
            get { return n; }
            set { n = value; }
        }

        public string O
        {
            get { return o; }
            set { o = value; }
        }

        public string B
        {
            get { return b; }
            set { b = value; }
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public ClassA()
        {
            n = "unknown name";
            o = "unknown owner";
            b = "unknown breed";
            a = 1;
        }

        public ClassA(string nn, string oo, string bb, int aa)
        {
            n = nn;
            o = oo;
            b = bb;
            a = aa;
        }

        public override string ToString()
        {
            return "Cat name: " + n + " Age: " + a;
        }
    }
}
