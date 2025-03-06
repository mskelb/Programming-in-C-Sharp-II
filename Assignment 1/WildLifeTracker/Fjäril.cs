using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeTrackerForm
{
    public class Fjäril : Insekt
    {
        public bool IsBeautiful { get; set; }
        public Fjäril(string name, int age, string gender, bool isBeautiful)
            : base(name, age, gender, false)
        {
            IsBeautiful = isBeautiful;
        }
        public override string ToString()
        {
            return base.ToString() + $"Art: Fjäril\r\nÄr den vacker?: {(IsBeautiful ? "Ja" : "Nej")}\r\n";
        }
    }
}
