using System;
namespace olioohjelmointi
{
    class WashingMachine
    {
        public bool IsWashingMachineOn { get; set; }
        public int Spincycle { get; set; }
        public int WaterTemperature { get; set; }

        public String GetSettings()
        {
            if (IsWashingMachineOn == true)
            {
                return "The washing machine is on and the water temperature is " + WaterTemperature + " degrees and spin cycle is se to " + Spincycle;
            }
            else
            {
                return "The washing machine is off";
            }
        }
        public String StartWashing(int answer)
        {
            if (IsWashingMachineOn == true && answer == 1)
            {
                return "Washing is starting";
               
            }
            else
            {
                return "The washing machine is off";
            }
        }
    }
    public class t7
    {
        static void Main()
        {
            WashingMachine laundry = new WashingMachine();
            laundry.IsWashingMachineOn = true;
            laundry.WaterTemperature = 40;
            laundry.Spincycle = 1200;

            Console.WriteLine(laundry.GetSettings());
            Console.WriteLine("Start washing? type 1 for yes and 2 for no: ");
            string ans = Console.ReadLine();
            Console.WriteLine(laundry.StartWashing(Int32.Parse(ans)));
            
        }
    }
}

