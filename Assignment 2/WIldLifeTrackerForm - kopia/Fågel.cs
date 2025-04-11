using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public abstract class Fågel : Djur
    {
        public int Wingspan { get; set; }
        public Fågel(string name, int age, Gender gender, bool isDomesticated, int wingspan, string imagePath)
            : base(name, age, gender, Category.Fågel, EaterType.Omnivore, isDomesticated, imagePath)
        {
            Wingspan = wingspan;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.FågelVingbredd.GetDescription()}: {Wingspan} cm\r\n";
        }
    }
}
