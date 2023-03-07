using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace olioohjelmointi
{
    public class Employee
    {
        public string Name { get; set; }
        public string Profession { get; set; }
        public int Salary { get; set; }
        public Employee(string name, string profession, int salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Name: {Name} Profession: {Profession}, Salary: {Salary}";
        }
    }
    public class Boss : Employee
    {
        public string Car { get; set; }
        public int Bonus { get; set; }
        public List<Employee> Employees { get; set; }
        
        public Boss(string name, string profession, int salary, string car, int bonus) 
            : base(name, profession, salary)
        {
            Name = name;
            Profession = profession;
            Salary = salary;
            Car = car;
            Bonus = bonus;
        }

        public override string ToString() { return $"Name: {Name} Profession: {Profession}, Salary: {Salary}, Car: {Car}, Bonus: {Bonus}";}

    }

    internal class T15
    {
        public static void Test()
        {
            Employee emp = new Employee("Kirsi Kernel", "Teacher", 1200);
            
            Boss boss = new Boss("Hanna Husso", "Head of Institute", 4000, "BMW", 1000);
    
            Console.WriteLine("Employee:");
            Console.WriteLine(emp);
            Console.WriteLine("Boss:");
            Console.WriteLine(boss);
            emp.Salary = 2000;
            Console.WriteLine("Employee:");
            Console.WriteLine(emp);
           
        }
        static void Task15()
        {
            Test();
        }
    }
}
