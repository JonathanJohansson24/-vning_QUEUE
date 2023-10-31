using System;

namespace Övning_QUEUE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient("Covid", "2023:10:31", 450313, "Agda Svensson", 78, "Patient", false, false);
            Patient p2 = new Patient("Kol", "2022:08:31", 370215, "Göran Hellkvist", 86, "Patient", false, false);
            Patient p3 = new Patient("Urinvägsinfektion", "2022:11:03", 921102, "Sven Wolter", 70, "Patient", false, false);
            Patient p4 = new Patient("Brutet ben", "2019:09:17", 921102, "Sven Svensson", 30, "Patient", false, false);
            Patient p5 = new Patient("Ebola", "2016:04:31", 900528, "Alexander Johansson", 73, "Patient", false, false);
            Doctor d1 = new Doctor(56000, 40, 870529, "Sven Gunnarsson", 33, "Läkare", true);
            List<Patient> patientList = new List<Patient>();
            patientList.Add(p1);
            patientList.Add(p2);
            patientList.Add(p3);
            patientList.Add(p4);
            patientList.Add(p5);
            List<Person> persons = new List<Person> ();
            persons.Add(d1);
            persons.Add(p1);
            persons.Add(p2);
            persons.Add(p3);
            persons.Add(p4);
            persons.Add(p5);

            foreach (Person people in persons)
            {
                people.PrintInfo();
                Console.ReadKey();
            }

            Queue<Patient> vaccinationQueue = new Queue<Patient>();
            vaccinationQueue.Enqueue(p1);
            vaccinationQueue.Enqueue(p2);
            vaccinationQueue.Enqueue(p3);
            vaccinationQueue.Enqueue(p4);
            vaccinationQueue.Enqueue(p5);


            while (vaccinationQueue.Count > 0)
            {
                Patient person = vaccinationQueue.Dequeue();
                person.Vaccinated = true;
                
                Console.WriteLine($"{person.Name} behandlad har blivit vaccinerad");
                Console.WriteLine($"Kön för vaccination är just nu :{vaccinationQueue.Count()}"); 
                Console.ReadKey();
            }
            //for (int i = 0; i <= 3; i++)
            //{

            //    foreach (Patient person in vaccinationQueue)
            //    {
            //        person.PrintInfo();
            //        Console.WriteLine();
            //        Console.ReadKey();


                    
                   

            //    }
            //            vaccinationQueue.Dequeue();
            //}



        }
    }
}