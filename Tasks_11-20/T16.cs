using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioohjelmointi
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Model { get; set; }
        public int YearModel { get; set; }
        public string Color { get; set; }
        public Vehicle(string name, string model, int yearmodel, string color)
        {
            Name = name;
            Model = model;
            YearModel = yearmodel;
            Color = color;
        }
        public override string ToString()
        {
            return $"- Name: {Name} Model: {Model}, Model year: {YearModel}, Color: {Color}";
        }
    }
    public class Bike : Vehicle
    {
        public bool IsGeared { get; set; }
        public string GearModelName { get; set; }
    
        public Bike(string name, string model, int yearmodel, string color, bool geared, string gearmodel) 
            : base(name, model, yearmodel, color)
        {
            Name = name;
            Model = model;
            YearModel = yearmodel;
            Color = color;
            IsGeared = geared;
            GearModelName = gearmodel;
        }

        public override string ToString() { return $"- Name: {Name} Model: {Model}, Model year: {YearModel}, Color: {Color}, Geared: {IsGeared}, Gear model name: {GearModelName}";}

    }
    public class Boat : Vehicle
    {
        public string Type { get; set; }
        public int Seats { get; set; }
        
        public Boat(string name, string model, int yearmodel, string color, string type, int seats) 
            : base(name, model, yearmodel, color)
        {
            Name = name;
            Model = model;
            YearModel = yearmodel;
            Color = color;
            Type = type;
            Seats = seats;
        }

        public override string ToString() { return $"- Name: {Name}, Model: {Model}, Model year: {YearModel}, Color: {Color}, Boat Type: {Type}, Seats: {Seats}";}

    }
    internal class T16
    {
        public static void Test()
        {
            Bike bike1 = new Bike("Jopo", "Street", 2020, "Yellow", false, "");
            Bike bike2 = new Bike("Helkama", "Street Hybrid", 2010, "Gray", true, "best gear");
            
            Boat boat1 = new Boat("Yamaha", "S900", 2000, "White", "RowBoat", 4);
            Boat boat2 = new Boat("Terhi", "Supercharge", 2015, "White", "Motorboat", 5);
    
            Console.WriteLine("Bike 1:");
            Console.WriteLine(bike1);
            Console.WriteLine("Bike 2:");
            Console.WriteLine(bike2);
            Console.WriteLine("Boat 1:");
            Console.WriteLine(boat1);
             Console.WriteLine("Boat 2:");
            Console.WriteLine(boat2);
        }
        static void Task16()
        {
            Test();
        }
    }
}