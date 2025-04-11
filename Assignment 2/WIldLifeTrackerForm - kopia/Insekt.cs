using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public abstract class Insekt : Djur
    {
        public bool IsPollinator { get; set; }
        public Insekt(string name, int age, Gender gender, bool isDomesticated, bool isPollinator, string imagePath)
            : base(name, age, gender, Category.Insekt, EaterType.Herbivore, isDomesticated, imagePath)
        {
            IsPollinator = isPollinator;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.BiFjärilPollinerar.GetDescription()} {(IsPollinator ? "Ja" : "Nej")} \r\n";
        }
    }
}
