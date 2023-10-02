using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp1
{
    public class Car  //Defining Car class
    {
        public string Brand;
        public string Model;
        public string Color;
        public string Registration_Number;
        public string Arrival_Time;
        public string Departure_Time;


        public Car(string brand, string model, string color, string registration_number, string arrival_time, string departure_time) //Container defining
        {
            Brand = brand;
            Model = model;
            Color = color;
            Registration_Number = registration_number;
            Arrival_Time = arrival_time;
            Departure_Time = departure_time;

        }
    }
}
