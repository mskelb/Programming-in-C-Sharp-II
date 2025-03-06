using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeTrackerForm
{
    public class Bi : Insekt
    {
        public bool IsCute { get; set; }
        public Bi(string name, int age, string gender, bool isCute)
            : base(name, age, gender, true)
        {
            IsCute = isCute;
        }
        public override string ToString()
        {
            return base.ToString() + $"Art: Bi\r\nSöt?: {(IsCute ? "Ja" : "Nej")}\r\n";
        }
    }
}
