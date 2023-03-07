using System;
using System.Collections.Generic;

namespace olioohjelmointi
{
    class Tank
    {
        public string? Name { get; set; }
        public string? Type { get; set; }
        private int crewNumber = 4;
        private float Speed = 0;
        private float SpeedMax { get; } = 100;

        public int CrewNumber  
        {  
            get  
            {  
                return crewNumber;  
            }  
            set  
            {  
                if(CrewNumber > 2 && CrewNumber <= 6) 
                {
                    crewNumber = value;
                }
                else Console.WriteLine("Crew must be between 2 and 6 people");
            
            }  
        }   
        public float AccelerateTo(float value) 
        {
            if(value > 0 && value <= SpeedMax) 
            {              
                Speed = value;
                return Speed;
            }
            else return Speed;
        }

        public float SlowTo(float value) 
        {
            if(value > 0 && value <= SpeedMax) 
            {
                Speed = value;
                return Speed;
            }
            else return Speed;
        }

        public void TestTank(Tank tank) 
        {
            tank.Name = "tankkeri";
            tank.Type = "War Tank";
            tank.CrewNumber = 5;
            tank.AccelerateTo(50);
            tank.SlowTo(20);
            Console.WriteLine("Tank name is: " + tank.Name + ", Tank type is: " + tank.Type + ", Tanks crew number is: " + tank.CrewNumber + " and tanks current speed is: " + tank.SlowTo(20));

        }
    }
    public class t12
    {
        static void T12()
        {
            Tank tank = new Tank();

            tank.TestTank(tank);
        }
    }
}