using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Fjäril : Insekt
    {
        public bool IsBeautiful { get; set; }
        public Fjäril(string name, int age, Gender gender, bool isDomesticated, bool isPollinator, bool isBeautiful, string imagePath)
            : base(name, age, gender, isDomesticated, isPollinator, imagePath)
        {
            IsBeautiful = isBeautiful;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.FjärilVacker.GetDescription()} {(IsBeautiful ? "Ja" : "Nej")}\r\n";
        }
        public override FoodSchedule GetFoodSchedule()
        {
            var schedule = new FoodSchedule();
            schedule.AddFoodItem("Morgon: Blomnektar");
            schedule.AddFoodItem("Lunch: Ännu mer blomnektar");
            schedule.AddFoodItem("Kväll: Manuka honung + Netflix");
            return schedule;
        }
    }
}
