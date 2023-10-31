using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_QUEUE
{
    internal class Nurse : Person
    {
       
        public int Salary { get; set; }

        public int WorkHours { get; set; }

        public Nurse(int salary, int workHours, int socNumber, string name, int age, string role, bool workingAtHospital) : base(socNumber, name, age, role, workingAtHospital)
        {
           
            Salary = salary;
            WorkHours = workHours;
        }
        public void BloodTest()
        {

        }
        public override void PrintInfo()
        {
            if (!WorkingAtHospital)
            {
                Console.WriteLine($"\t\t\t{Name} is not working at the hospital");
            }
            else
            {
                Console.WriteLine($"\t\t\t{Name} is working at the hospital");
            }
            Console.WriteLine(@$"
Role = {Role}
Salary = {Salary}
Security Number = {SocialNumber}
Name = {Name}
Age = {Age}
Working hours/week = {WorkHours}");

        }

    }
}
