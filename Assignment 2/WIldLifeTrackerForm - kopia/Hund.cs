using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Hund : Däggdjur
    {
        public bool LikesBalls { get; set; }
        public Hund(string name, int age, Gender gender, bool isDomesticated, int numberOfTeeth, bool likesBalls, string imagePath)
            : base(name, age, gender, isDomesticated, numberOfTeeth, imagePath)
        {
            LikesBalls = likesBalls;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.HundGillarBollar.GetDescription()} {(LikesBalls ? "Ja" : "Nej")}\r\n";
        }

        public override FoodSchedule GetFoodSchedule()
        {
            var schedule = new FoodSchedule();
            schedule.AddFoodItem("Morgon: Köttben och mys med matte");
            schedule.AddFoodItem("Lunch: Entrecote...rare done...");
            schedule.AddFoodItem("Kväll: Köttbullar och sås");
            return schedule;
        }
    }
}
