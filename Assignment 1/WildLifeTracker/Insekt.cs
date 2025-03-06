using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Insekt : Djur
    {
        public bool IsPolinater { get; set; }
        public Insekt(string name, int age, string gender, bool isPolinater)
            : base(name, age, gender, "Insekt", false)
        {
            IsPolinater = isPolinater;
        }
        public override string ToString()
        {
            return base.ToString() + $"Pollinerare?: {(IsPolinater ? "Ja" : "Nej")}\r\n";
        }
    }
}
