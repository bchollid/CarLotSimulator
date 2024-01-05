using System;
namespace CarLotSimulator
{
	public class Car
    {
        public Car()
        {

        }
        public int Year { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public string EngineNoise { get; set; }

        public string HonkNoise { get; set; }

        public bool IsDriveable { get; set; }

        public void MakeEngineNoise(string EngineNoise)
        {
            Console.WriteLine(EngineNoise);
        }

        public void MakeHonkNoise(string HonkNoise)
        {
            Console.WriteLine(HonkNoise);
        }

        public Car(string make, string model, int year, bool isDriveable, string honkNoise, string engineNoise)
        {
            Make = make;
            Model = model;
            Year = year;
            IsDriveable = isDriveable;
            HonkNoise = honkNoise;
            EngineNoise = engineNoise;
        }

    }
}

