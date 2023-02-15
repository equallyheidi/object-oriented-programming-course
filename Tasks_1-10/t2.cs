using System;
using System.Linq;

namespace olioohjelmointi
{
	public class T2
	{
		public static void Main()
		{
            int[] arr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Give points: ");

                string numString = Console.ReadLine();
                int points;
                bool canConvert = int.TryParse(numString, out points);
                if (canConvert == true)
                {
                    arr[i] = points;
                }
                else
                    Console.WriteLine("Given amount is not a number");
                
            }

            int max = arr.Max();
            int min = arr.Min();
            int sum = arr.Sum();

            int outcome = sum - max - min;

            Console.WriteLine("Total points are: " + outcome);


        }
	}
}

