using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildlifeTracker;

namespace WildLifeTrackerForm
{
    public class Falk : Fågel
    {
        public int FlightSpeed { get; set; }

        public Falk(string name, int age, Gender gender, bool isDomesticated, int wingspan, int flightSpeed, string imagePath)
            : base(name, age, gender, isDomesticated, wingspan, imagePath)
        {
            FlightSpeed = flightSpeed;
        }
        public override string GetExtraInfo()
        {
            return base.GetExtraInfo() + $"{AnimalPrompts.FalkFlyghastighet.GetDescription()}: {FlightSpeed} km/h\r\n";
        }
        public override FoodSchedule GetFoodSchedule()
        {
            var schedule = new FoodSchedule();
            schedule.AddFoodItem("Morgon: Fastar tills lunch");
            schedule.AddFoodItem("Lunch: Friterade insekter");
            schedule.AddFoodItem("Kväll: Milkshake med glass och torkade insekter");
            return schedule;
        }
    }
}
