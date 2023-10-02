namespace ParkingApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parking parking = new Parking(); //Creating a new object of Parking class

            parking.cars_on_parking = new List<Car>(); //Creating a new list of cars on parking

            // Code  block for adding predefined values to the list of cars on parking
            parking.cars_on_parking.Add(new Car("Ford", "Focus Titanium", "Blue", "AI2012HB", "2023-09-30T14:50:06", "2023-09-30T16:50:06"));
            parking.cars_on_parking.Add(new Car("Audi", "TT", "Silver", "AH3333BK", "2023-10-01T11:17:36", "2023-10-01T14:51:09"));
            parking.cars_on_parking.Add(new Car("Toyota", "RAV-4", "White", "AX5033VT", "2023-10-01T10:33:11", "2023-10-01T16:45:25"));

            parking.AddNewCar();  // Calling the method for adding a new car to parking (console input by user)

            Console.WriteLine();
            Console.WriteLine("Ford cars statistics:");
            Console.WriteLine();

            foreach (Car car in parking.cars_on_parking)   //Console output by condition: output registration numbers and departure time of all cars of brand "Ford"  
            {
                if (car.Brand == "Ford")
                {
                    Console.WriteLine($"Car registration_number :{car.Registration_Number}");
                    Console.WriteLine($"departure_time :{car.Departure_Time}");
                }
            }
            parking.CarsInfoConsoleOutput();    //Console output of detailed information of full list of cars on the parking.
        }
    }
}