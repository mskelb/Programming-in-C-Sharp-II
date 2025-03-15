using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Katt : Däggdjur
    {
        public double CutenessIndex { get; set; }

        public Katt(string name, int age, Gender gender, bool isDomesticated, int numberOfTeeth, int cutenessIndex, string imagePath)
            : base(name, age, gender, isDomesticated, numberOfTeeth, imagePath)
        {
            CutenessIndex = cutenessIndex;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.KattSötindex.GetDescription()} {CutenessIndex}\r\n";
        }
        public override FoodSchedule GetFoodSchedule()
        {
            var schedule = new FoodSchedule();
            schedule.AddFoodItem("Morgon: Latte med mjölk");
            schedule.AddFoodItem("Lunch: Glutenfria kattkex");
            schedule.AddFoodItem("Kväll: Fisk och mjölk");
            return schedule;
        }
    }
}
