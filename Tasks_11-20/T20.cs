using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioohjelmointi
{
    abstract class Mammal  
    {
        public int age;
        public abstract int Age { get; set; } 
        public abstract void Move();
    }
    
    class Human : Mammal
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }

        public override int Age 
        {   get 
            {
                return age;
            } 
            set 
            {
                age = value;
            }
        }
        
        public override void Move() 
        {
            Console.WriteLine("Moving..");
        }
        
        public string Grow() 
        {
            return Name + " is now " + (age += 1); 
        }
        
    }
    class Baby : Human
    {
        public override void Move() 
        {
            Console.WriteLine(Name + " is Crawling..");
        }

        public string Diaper() 
        {
            return $"Baby {Name} is in diapers";
        }
    }

    class Adult : Human
    {
        public override void Move() 
        {
            Console.WriteLine(Name + " is Walking..");
        }

        public override string ToString() { return $"Name is: {Name}, age is: {Age}, height is: {Height}cm and weight is: {Weight}kg";}
    }
    
    internal class T20
    {
        public static void Test()
        {
            Adult adult1 = new Adult();
            adult1.Name = "Paavo";
            adult1.Height = 180;
            adult1.Weight = 80;
            adult1.Age = 30;
            Console.WriteLine(adult1);
            Console.WriteLine(adult1.Grow());
            adult1.Move();

            Adult adult2 = new Adult();
            adult2.Name = "Heli";
            adult2.Height = 160;
            adult2.Weight = 55;
            adult2.Age = 23;
            Console.WriteLine(adult2);
            Console.WriteLine(adult2.Grow());
            adult2.Move();

            Baby baby1 = new Baby();
            baby1.Name = "Pekka";
            Console.WriteLine(baby1.Diaper());
            baby1.Move();

            Baby baby2 = new Baby();
            baby2.Name = "Vilho";
            Console.WriteLine(baby2.Diaper());
            baby2.Move();
 
        }
        static void Task20()
        {
            Test();
        }
    }
}