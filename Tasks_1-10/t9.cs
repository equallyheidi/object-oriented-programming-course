using System;
namespace olioohjelmointi
{
    class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Speed { get; set; }
        public int Tires { get; set; }

        public Vehicle(string brand, string model, int speed, int tires)
        {
            Brand = brand;
            Model = model;
            Speed = speed;
            Tires = tires;

        }

        public String ShowInfo() {  return "Manufacturer is " + Brand + " and the model is " + Model; }

        public override String ToString() { return "Manufacturer is " + Brand + ", the model is " + Model + ", Speed is " + Speed + "and tires are " + Tires + " inches"; }
        
            
    }
    public class t9
    {
        static void Main()
        {
            Vehicle motorcycle = new Vehicle("Suzuki", "RM", 90, 28);
            Vehicle car = new Vehicle("Audi", "A6", 120, 29);

            motorcycle.Speed += 20;
            motorcycle.Tires -= 1;

            car.Model = "A4";
            car.Tires = 28;

            Console.WriteLine(motorcycle.ShowInfo());
            Console.WriteLine(car.ToString());

        }
    }
}

