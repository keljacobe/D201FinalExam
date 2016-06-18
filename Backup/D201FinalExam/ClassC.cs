using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D201FinalExam
{
    class ClassC
    {
        public List<ClassA> CCMethod1(List<ClassA> cts, int g)
        {
            List<ClassA> res = new List<ClassA>();

            for(int i = 0; i < cts.Count; i++)
            {
                if (cts[i].A > g)
                {
                    res.Add(cts[i]);
                }
            }
            return res;
        }

        public List<ClassA> CCMethod2(List<ClassA> cts, int g)
        {
            List<ClassA> res = new List<ClassA>();

            for (int i = 0; i < cts.Count; i++)
            {
                if (cts[i].A < g)
                {
                    res.Add(cts[i]);
                }
            }
            return res;
        }

        public List<ClassA> CCMethod3(List<ClassA> cts, int g)
        {
            List<ClassA> res = new List<ClassA>();

            for (int i = 0; i < cts.Count; i++)
            {
                if (cts[i].A == g)
                {
                    res.Add(cts[i]);
                }
            }
            return res;
        }
    }
}