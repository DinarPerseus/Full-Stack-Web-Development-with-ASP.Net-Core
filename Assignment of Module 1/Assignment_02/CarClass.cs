namespace Assignment
{
    public class Car
    {
        //task 1
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int Mileage { get; set; }
        public void Drive(int kilometers)
        {
            Mileage += kilometers;
            Console.WriteLine($"Car {Brand} {Model} has driven {kilometers} km. Total mileage: {Mileage} km.");

        }
        //end of task 1


        //task 3
        public void ShowCarInfo()
        {
            Console.WriteLine($"Car Info: Brand - {Brand}, Model - {Model}, Year - {Year}, Mileage - {Mileage}");
        }
        //end of task 3
    }
}