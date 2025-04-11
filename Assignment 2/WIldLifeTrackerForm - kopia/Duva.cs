using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Duva : Fågel
    {
        public bool IsPeaceDove { get; set; }

        public Duva(string name, int age, Gender gender, bool isDomesticated, int wingspan, bool isPeaceDove, string imagePath)
            : base(name, age, gender, isDomesticated, wingspan, imagePath)
        {
            IsPeaceDove = isPeaceDove;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.DuvaFridensDuva.GetDescription()} {(IsPeaceDove ? "Ja" : "Nej")}\r\n";
        }
        public override FoodSchedule GetFoodSchedule()
        {
            var schedule = new FoodSchedule();
            schedule.AddFoodItem("Morgon: Frön och bär");
            schedule.AddFoodItem("Lunch: Latte med extra smak av larver");
            schedule.AddFoodItem("Kväll: Frön + Netflix");
            return schedule;
        }
    }
}
