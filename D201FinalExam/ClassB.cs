using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace D201FinalExam
{
    class ClassB
    {
        public bool CBMethod1(string fn, ClassA ca)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fn, true);
                sw.WriteLine(ca.N + "*" + ca.O + "*" + ca.B + "*" + ca.A);
                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<ClassA> CBMethod2(string fn)
        {
            try
            {
                List<ClassA> cts = new List<ClassA>();

                StreamReader sr = new StreamReader(fn);

                while (!sr.EndOfStream)
                {
                    string x = sr.ReadLine();
                    string[] y = x.Split('*');

                    ClassA z = new ClassA(y[0], y[1], y[2], int.Parse(y[3]));

                    cts.Add(z);
                }

                return cts;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool CBMethod3(string fn, List<ClassA> cts, string t, int g)
        {
            try
            {
                StreamWriter sw = new StreamWriter(fn, false);
                sw.WriteLine("Cats " + t + " the age of: " + g + "\n");

                foreach (ClassA ca in cts)
                {
                    sw.WriteLine(ca.N + "\t" + ca.O + "\t" + ca.B + "\t" + ca.A);
                }
                sw.Close();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}