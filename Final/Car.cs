using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final
{
    public class Car
    {
        // properties
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int SerialNumber { get; set; }
        public DateTime ProductionDate { get; set; }
        public int DoorCount { get; set; }
        public Car()
        {
            ProductionDate = DateTime.Now; // constructor method automatically assigns the production date when the car is manufactured
        }
    }
}
