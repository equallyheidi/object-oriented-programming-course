using System;
namespace olioohjelmointi
{
    class Heater
    {
        public bool IsSaunaOn { get; set; }
        public int Temperature { get; set; }
        public int Humidity { get; set; }

        public String GetSaunaSettings()
        {
            if(IsSaunaOn == true)
            {
                return "Sauna is on and the temperature is " + Temperature + " degrees and humidity is " + Humidity + "%";
            }
            else
            {
                return "Sauna is off";
            }
        }
    }
	public class t6
	{
        static void Main()
        {
            Heater sauna = new Heater();
            sauna.IsSaunaOn = true;
            sauna.Temperature = 80;
            sauna.Humidity = 30;
            Console.WriteLine(sauna.GetSaunaSettings());

            sauna.IsSaunaOn = false;
            Console.WriteLine(sauna.GetSaunaSettings());

        }
    }
    
}

