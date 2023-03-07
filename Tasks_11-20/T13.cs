using System;
using System.Collections.Generic;

namespace olioohjelmointi
{
    class Elevator
    {
        public int Floor { get; set; } = 1;
        
        public string MoveTo(int floor, out string message) 
        {
            if(floor >= 1 && floor <= 5) 
            {              
                Floor = floor;
                message = "Moving to floor: " + Floor.ToString();
                return message;
            }
            if(floor < 1) 
            {
                message = "Floor is too small";
                return message;
            }
            if(floor > 5) 
            {
                message = "Floor is too large";
                return message;
            }
            else
            {
                message = "floor is not valid";
                return message;
            } 
        }

    }
    public class t13 
    {
        static void T13()
        {
            Elevator elevator = new Elevator();
            string message = "";
            int floor = 1;

          for(int i = 0; i < 4; i++) {
                Console.WriteLine("Elevator in now on floor: " + elevator.Floor);
                Console.WriteLine("Enter the floor  number 1-5: ");
                floor = Int32.Parse(Console.ReadLine());
                Console.WriteLine(elevator.MoveTo(floor, out message));
               
            }
        }
    }
}