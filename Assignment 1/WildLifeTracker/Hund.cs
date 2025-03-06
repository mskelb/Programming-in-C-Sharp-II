using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeTrackerForm
{
    public class Hund : Däggdjur
    {
        public bool LikesBalls { get; set; }

        public Hund(string name, int age, string gender, bool isDomesticated, int nrOfTeeths, bool likesBalls)
            : base(name, age, gender, isDomesticated, nrOfTeeths)
        {
            LikesBalls = likesBalls;
        }

        public override string ToString()
        {
            return base.ToString() + $"Art: Hund\r\nGillar bollar?: {(LikesBalls ? "Ja" : "Nej")}\r\n";
        }
    }
}
