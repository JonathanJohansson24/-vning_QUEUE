using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_QUEUE
{
    internal class Patient : Person
    {
        public string Disease { get; set; }

        

        public bool Vaccinated { get; set; }
        public string TimeOfReg { get; set; }

        public Patient(string disease, string timeOfReg, int socNumber, string name, int age, string role, bool workingAtHospital,  bool vaccinated) : base(socNumber, name, age, role, workingAtHospital)
        {
            Disease = disease;
            TimeOfReg = timeOfReg;
            Vaccinated = vaccinated;
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
Date of Reg = {TimeOfReg}
Security Number = {SocialNumber}
Name = {Name}
Age = {Age}
Disease = {Disease}");
            if (!Vaccinated)
            {
                Console.WriteLine($"{Name} is not Vaccinated");
                
            }
            else
            {
                Console.WriteLine($"{Name} is Vaccinated");
            }

        }
    }
}
