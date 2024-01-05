using System;

namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            var carLot = new CarLot();

            var ford = new Car();

            ford.Make = "Ford";
            ford.Model = "F150";
            ford.Year = 2020;
            ford.IsDriveable = true;
            ford.HonkNoise = "Errrrrrrr";
            ford.EngineNoise = "Rumrumrumrum";

            carLot.totalCars.Add(ford);

            var bmw = new Car()
            {
             Make = "BMW",
             Model = "X5",
             Year = 2023,
             IsDriveable = true,
             HonkNoise = "Wahhhhhhh",
             EngineNoise = "Vrooooom",
            };

            carLot.totalCars.Add(bmw);

            var honda = new Car("Honda", "Civic", 2005, false, "Blaaaaaaaa", "This engine doesn't run. No noise applicable.");

            carLot.totalCars.Add(honda);

            Console.WriteLine("-------------------------------------");

            Console.WriteLine($"The {ford.Year} {ford.Make} {ford.Model} make these noises.");
            ford.MakeEngineNoise(ford.EngineNoise);
            ford.MakeHonkNoise(ford.HonkNoise);
            Console.WriteLine($"The {bmw.Year} {bmw.Make} {bmw.Model} make these noises.");
            bmw.MakeEngineNoise(bmw.EngineNoise);
            bmw.MakeHonkNoise(bmw.HonkNoise);
            Console.WriteLine($"The {honda.Year} {honda.Make} {honda.Model} make these noises.");
            honda.MakeEngineNoise(honda.EngineNoise);
            honda.MakeHonkNoise(honda.HonkNoise);

            Console.WriteLine("-------------------------------------");

            foreach(var carInTheLot in carLot.totalCars)
            {
                Console.WriteLine($"Year: {carInTheLot.Year} Make: {carInTheLot.Make} Model: {carInTheLot.Model}");
            }
        }
    }
}
