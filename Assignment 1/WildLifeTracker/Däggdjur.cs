using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Däggdjur : Djur
    {
        public int NrOfTeeths { get; set; }

        public Däggdjur(string name, int age, string gender, bool isDomesticated, int nrOfTeeths)
            : base(name, age, gender, "Däggdjur", isDomesticated)
        {
            NrOfTeeths = nrOfTeeths;
        }

        public override string ToString()
        {
            return base.ToString() + $"Antal tänder: {NrOfTeeths}\r\n";
        }
    }
}
