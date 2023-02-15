using System;
namespace olioohjelmointi
{
	public class T3
	{
		public static void Consumption(ref double km, out double gas, out double cost)
		{
			Random r = new Random();
			
			double fuelPrice = r.NextDouble() * (2.50 - 1.75) + 1.75;
			double consumption = r.NextDouble() * (9.0 - 6.0) + 6.0;

            gas = (consumption / 100) * km;
			cost = fuelPrice * gas;

            gas = Math.Round(gas, 2);
            cost = Math.Round(cost, 2);

        }
		static void Main()
		{
            Console.WriteLine("Enter distance traveled: ");

            string numString = Console.ReadLine();
		
            double distance;
		
            bool canConvert = double.TryParse(numString, out distance);
            if (canConvert == true)
            {
                double gas, cost;
               
                Consumption(ref distance, out gas, out cost);
                Console.WriteLine("Fuel consumption is {0} liters and it costs {1} euros", gas, cost);
            }
            else
                Console.WriteLine("Given amount is not a number");
        }
	}
}

