using System;
using System.Collections.Generic;

namespace olioohjelmointi
{
    class Student
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        
        public Student(string name, string address, int age)
        {
            Name= name;
            Address = address;
            Age = age;
           
        }

        public override string ToString() { return "Student's name is " + Name + ", Address is  " + Address + " and Age is " + Age; }

    }
    public class t10
    {
        static void Main()
        {
            List<Student> students = new List<Student>();

            students.Add(new Student("Aatos", "osoite 2, 0000 jokukaupunki", 20));
            students.Add(new Student("Eero", "osoite 3, 0000 jokukaupunki", 22));
            students.Add(new Student("Anna", "osoite 4, 0000 jokukaupunki", 26));
            students.Add(new Student("Ulla", "osoite 5, 0000 jokukaupunki", 21));
            students.Add(new Student("Pekka", "osoite 6, 0000 jokukaupunki", 20));


            foreach (Student stu in students)
            {
                Console.WriteLine(stu);
            }

        }
    }
}

