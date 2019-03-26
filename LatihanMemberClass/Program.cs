using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat objek
            Taxi taxi = new Taxi();

            // pengeset nilai properties
            taxi.DriveName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            // pemanggilan method
            taxi.TaxiInfo();
            taxi.PickupPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
