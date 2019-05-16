using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_zest_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee();
            employee1.Name = "John";
            employee1.Surname = "Kowalski";
            employee1.Age = 25;
            employee1.HourlyRate = 30;

            Console.WriteLine(employee1.Name + " " + employee1.Surname
                + " earns " + employee1.CalculatePayment(140));

            Console.ReadKey();
        }
        class Human
        {
            public string Name { get; set; }
            public string Surname{ get; set; }
            public int Age { get; set; }
        }
        class Employee : Human
        {
            public string Position { get; set; }
            public float HourlyRate { get; set; }
            public float CalculatePayment(int hoursNumber)
            {
                return hoursNumber * HourlyRate;
            }
        }
    }
}
