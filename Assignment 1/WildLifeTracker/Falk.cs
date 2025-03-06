using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WildLifeTrackerForm
{
    public class Falk : Fågel
    {
        public double FlightSpeed { get; set; }
        public Falk(string name, int age, string gender, double wingSpan, double flightSpeed)
            : base(name, age, gender, wingSpan)
        {
            FlightSpeed = flightSpeed;
        }
        public override string ToString()
        {
            return base.ToString() + $"Art: Falk\r\nFlyghastighet: {FlightSpeed} km/h\r\n";
        }
    }
}
