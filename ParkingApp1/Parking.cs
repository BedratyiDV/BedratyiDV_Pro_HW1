using ParkingApp1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ParkingApp1
{
    public class Parking    //Defining of Parking class
    {
        public List<Car> cars_on_parking;  // Defining the field of Parking class that is a list of Car class objects 


        public void AddNewCar()  //Method for adding a new car to parking (to the list of cars that are on the parking)

        {
            Console.WriteLine("Please input a new car brand : ");  //Code block for console input of car description
            string brand = Console.ReadLine();
            Console.WriteLine("Please input a new car model : ");
            string model = Console.ReadLine();
            Console.WriteLine("Please input a new car color : ");
            string color = Console.ReadLine();
            Console.WriteLine("Please input a new car registration_number : ");
            string registration_number = Console.ReadLine();

            DateTime currentTime = DateTime.Now;              //Code block for defining the arrival and departure time
            string arrival_time = currentTime.ToString();     //Defining time of arrive as a current time
            DateTime futureTime = currentTime.AddHours(2);    //Defining time of departure as a current time plus two hours (it's to simplify)
            string departure_time = futureTime.ToString();

            Car new_car = new Car(brand, model, color, registration_number, arrival_time, departure_time); //Creating a new Car class object, initialized with car details defined above

            cars_on_parking.Add(new_car);  //Adding the new Car object to the list of cars on parking
            return;
        }
        public void CarsInfoConsoleOutput()  //Console output method for reviewing car information for all cars on the parking

        {
            foreach (Car car in cars_on_parking)

            {
                Console.WriteLine();
                Console.WriteLine($"Car brand : {car.Brand}");
                Console.WriteLine($"Car model :{car.Model}");
                Console.WriteLine($"Car color :{car.Color}");
                Console.WriteLine($"Car registration_nu :{car.Registration_Number}");
                Console.WriteLine($"arrival_time : {car.Arrival_Time}");
                Console.WriteLine($"departure_time :{car.Departure_Time}");

            }
            return;
        }

    }
}
