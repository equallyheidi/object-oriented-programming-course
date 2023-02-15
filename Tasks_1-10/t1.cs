using System;

namespace olioohjelmointi
{
    class Something
    {
        public static void Main()
        {
            Console.WriteLine("Enter points: ");
            
            string numString = Console.ReadLine(); 
            int points;
            bool canConvert = int.TryParse(numString, out points);
            if (canConvert == true)
            {
                if (points >= 0 && points <= 19)
                {
                    Console.WriteLine("Your grade is: 0");
                }
                else if (points >= 20 && points <= 29)
                {
                    Console.WriteLine("Your grade is: 1");
                }
                else if (points >= 30 && points <= 39)
                {
                    Console.WriteLine("Your grade is: 2");
                }
                else if (points >= 40 && points <= 49)
                {
                    Console.WriteLine("Your grade is: 3");
                }
                else if (points >= 50 && points <= 59)
                {
                    Console.WriteLine("Your grade is: 4");
                }
                else if (points >= 60 && points <= 70)
                {
                    Console.WriteLine("Your grade is: 5");
                }
                else
                    Console.WriteLine("Given value is out of range");
            }
            else
                Console.WriteLine("Given value is not a number");

        }
        
    }
}
