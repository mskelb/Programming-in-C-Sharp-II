using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Fågel : Djur
    {
        public double WingSpan { get; set; }
        public Fågel(string name, int age, string gender, double wingSpan)
            : base(name, age, gender, "Fågel", false)
        {
            WingSpan = wingSpan;
        }
        public override string ToString()
        {
            return base.ToString() + $"Vingspann: {WingSpan} cm\r\n";
        }
    }
}
