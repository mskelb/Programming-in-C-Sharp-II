using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeTrackerForm
{
    public class Duva : Fågel
    {
        public bool IsPeaceDove { get; set; }
        public Duva(string name, int age, string gender, double wingSpan, bool isPeaceDove)
            : base(name, age, gender, wingSpan)
        {
            IsPeaceDove = isPeaceDove;
        }
        public override string ToString()
        {
            return base.ToString() + $"Art: Duva\r\nFridens duva?: {(IsPeaceDove ? "Ja" : "Nej")}\r\n";
        }
    }
}
