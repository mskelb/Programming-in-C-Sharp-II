using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public abstract class Däggdjur : Djur
    {
        public int NumberOfTeeth { get; set; }

        public Däggdjur(string name, int age, Gender gender, bool isDomesticated, int numberOfTeeth, string imagePath)
            : base(name, age, gender, Category.Däggdjur, EaterType.Carnivore, isDomesticated, imagePath)
        {
            NumberOfTeeth = numberOfTeeth;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.Tänder.GetDescription()}: {NumberOfTeeth} st\r\n";
        }
    }
}
