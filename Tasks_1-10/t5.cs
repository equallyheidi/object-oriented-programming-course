using System;
using System.Collections.Generic;

namespace olioohjelmointi
{
    struct People
    {
        public int year;
       
        public string name;

       
        public People(int birthYear, string personsName)
        {
            
            year = birthYear;
            name = personsName;
           
        }
 
    }

	public class T5
    {
        static void Main()
		{
          
            List<People> persons = new List<People>();

            string nameAndBirthYear;
           
            bool input = true;
            
            do
            {
                Console.WriteLine("Please, give name and birth year of a person. Empty input will stop the input.");
                Console.WriteLine("Give a name: ");
                nameAndBirthYear = Console.ReadLine();

                if (string.IsNullOrEmpty(nameAndBirthYear))
                {
                    Console.WriteLine(" ...");
                    Console.WriteLine(persons.Count + " names are given:");

                    foreach (People person in persons)
                    {
                        Console.WriteLine(person.name + " is " + person.year + " years old.");
                    }
                    input = false;
                }
                else
                {
                    var name = nameAndBirthYear.Split(',')[0];
                    var birthYear = nameAndBirthYear.Split(',')[1];

                    persons.Add(new People() { name = name, year = 2023 - Int32.Parse(birthYear) });
                }
            } while (input == true); 
        }
	}
}

