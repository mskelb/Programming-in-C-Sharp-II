using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeTrackerForm
{
    public class Katt : Däggdjur
    {
        public double CutenessIndex { get; set; }

        public Katt(string name, int age, string gender, bool isDomesticated, int nrOfTeeths, int cutenessIndex)
            : base(name, age, gender, isDomesticated, nrOfTeeths)
        {
            CutenessIndex = cutenessIndex;
        }
        public override string ToString()
        {
            return base.ToString() + $"Art: Katt\r\nSöthetsindex: {CutenessIndex}\r\n";
        }
    }
}
