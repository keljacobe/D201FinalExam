using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D201FinalExam
{
    class ClassD
    {
        public List<ClassA> CDMethod1(List<ClassA> cts)
        {
            for (int i = 0; i < cts.Count; i++)
            {
                for (int j = 0; j < cts.Count - 1; j++)
                {
                    if (cts[j].A > cts[j+1].A)
                    {
                        ClassA t = cts[j];
                        cts[j] = cts[j + 1];
                        cts[j + 1] = t;
                    }
                }
            }
            return cts;
        }

        public List<ClassA> CDMethod2(List<ClassA> cts)
        {
            List<ClassA> res = new List<ClassA>();
            int sc = cts.Count;
            ClassA t = cts[0];

            for (int i = 0; i < sc; i++)
            {
                for (int j = 0; j < cts.Count; j++)
                {
                    if (cts[j].A > t.A)
                    {
                        t = cts[j];
                    }
                }
                res.Add(t);
                cts.Remove(t);

                if (cts.Count != 0)
                {
                    t = cts[0];
                }
            }
            return res;
        }

        public List<ClassA> CDMethod3(List<ClassA> cts)
        {
            cts = cts.OrderBy(x => x.N).ToList();

            return cts;
        }

        public List<ClassA> CDMethod4(List<ClassA> cts)
        {
            cts = cts.OrderByDescending(x => x.N).ToList();

            return cts;
        }
    }
}