using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Övning_QUEUE
{
    internal class Person
    {
        public string Name { get; set; }
        public int SocialNumber { get; set; }
        public int Age { get; set; }
        public string Role { get; set; }
        public bool WorkingAtHospital { get; set; }

        public Person(int socNumber, string name, int age, string role, bool workingAtHospital)
        {
            Name = name;
            SocialNumber = socNumber;
            Age = age;
            Role = role;
            WorkingAtHospital = workingAtHospital;

        }
        public virtual void PrintInfo()
        {

        }
    }
}
