using System;
using Assignment;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {

            //task 2

            Car myCar1 = new Car
            {
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2020,
                Mileage = 0
            };
            Car myCar2 = new Car
            {
                Brand = "Honda",
                Model = "Civic",
                Year = 2019,
                Mileage = 15000
            };

            myCar1.ShowCarInfo(); 
            myCar2.ShowCarInfo();
            myCar1.Drive(100); 
            myCar2.Drive(30);
            myCar1.Drive(50);

            myCar1.ShowCarInfo();
            myCar2.ShowCarInfo();

            Console.ReadLine();
            //end of task 2
        }
    }
}