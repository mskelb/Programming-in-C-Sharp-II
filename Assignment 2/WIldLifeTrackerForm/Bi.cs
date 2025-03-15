using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Bi : Insekt
    {
        public bool IsCute { get; set; }

        public Bi(string name, int age, Gender gender, bool isDomesticated, bool isPollinator, bool isCute, string imagePath)
            : base(name, age, gender, isDomesticated, isPollinator, imagePath)
        {
            IsCute = isCute;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.BiGulligt.GetDescription()} {(IsCute ? "Ja" : "Nej")}\r\n";
        }
        public override FoodSchedule GetFoodSchedule()
        {
            var schedule = new FoodSchedule();
            schedule.AddFoodItem("Morgon: Nektar och pollen");
            schedule.AddFoodItem("Lunch: Ännu mer nektar");
            schedule.AddFoodItem("Kväll: Lite mindre nektar");
            return schedule;
        }
    }
}
