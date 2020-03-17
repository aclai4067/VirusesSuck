using System;
using System.Collections.Generic;

namespace VirusesSuck
{
    class Program
    {
        static void Main(string[] args)
        {
            var covid19 = new Virus("COVID-19", 15);
            covid19.Symptoms.Add("Fever");
            covid19.Symptoms.Add("Dry Cough");
            covid19.Symptoms.Add("Shortness of breath");
            covid19.NumberOfDeathsWorldWide = 7158;

            var spanishFlu = new Virus("Spanish Flu", 11);
            spanishFlu.Symptoms.Add("Fever");
            spanishFlu.Symptoms.Add("Dry Cough");
            spanishFlu.NumberOfDeathsWorldWide = 50000000;

            var rabies = new Virus("Rabies", 11);
            rabies.Symptoms.Add("Excessive salivation");
            rabies.Symptoms.Add("Mental confusion");
            rabies.NumberOfDeathsWorldWide = 200000;

            var viruses = new List<Virus> { covid19, spanishFlu, rabies };

            foreach (var virus in viruses)
            {
                Console.WriteLine($"The {virus.Name} has an incubation period of {virus.IncubationDays} and has killed {virus.NumberOfDeathsWorldWide}.");
                Console.WriteLine($"It has the following symptoms: {string.Join(", ", virus.Symptoms)}");
            }


            //// ----------------------------------------------------------------------------------------------------
            //// Lists
            //// ----------------------------------------------------------------------------------------------------
            //var names = new List<string>();

            //// Add items one at a time
            //names.Add("COVID-19");
            //names.Add("Ebola");
            //names.Add("Spanish Flu");
            //names.Add("SARS");
            //names.Add("Rabies");
            //names.Add("Stupidity");
            //names.Insert(0, "Shebola");

            //// Remove items one at a time
            //names.Remove("Stupidity"); // remove by name
            //names.RemoveAt(0); // remove by index

            //// Add multiple at once
            //var people = new List<string>{ "Nathan", "Martin", "Randy's kid" };  // collection initializer
            //names.AddRange(people);

            //// Remove multiple at once
            //names.RemoveRange(names.Count - 3, 3);

            //foreach (var name in names)
            //{
            //    Console.WriteLine($"current virus name is {name}");
            //}

            //// ----------------------------------------------------------------------------------------------------
            //// Dictionaries
            //// ----------------------------------------------------------------------------------------------------
            //var symptoms = new Dictionary<string,string>(); // params: type of first entry (key), type of second entry (value)
            
            //// add single item
            //symptoms.Add("COVID-19", "Dry cough, fever, shortness of breath");
            //symptoms.Add("Ebola", "Fever, headache, muscle pin, and chills");
            //symptoms.Add("Spanish Flu", " fever, a dry cough, fatigue and difficulty breathing");
            //symptoms.Add("SARS", "Fever, dry cough, headache, muscle aches, and difficulty breathing");
            //symptoms.Add("Rabies", "Symptoms include fever, headache, excess salivation, muscle spasms, paralysis, and mental confusion.");
            //symptoms.Add("stomach-flu", "nausea, 💩, chills, loss of energy, not actually the flu");
            //// cannot have two items with the same key. same value does not matter

            //// get single thing
            //var CovidSymptoms = symptoms["COVID-19"];

            //// remove single item
            //symptoms.Remove("stomach-flu");

            //// add multiple with collection inititalizer
            //var otherDictionary = new Dictionary<string, int> { { "nathan", 33 }, { "martin", 36 }, { "ashley", 34 } };

            //foreach (var (virus, symptom) in symptoms) // (key, value)
            //{
            //    Console.WriteLine($"The symptoms of {virus} are {symptom}");
            //}

            //foreach (var name in names)
            //{
            //    if(symptoms.ContainsKey(name))
            //    {
            //        Console.WriteLine($"The symptoms of {name} are {symptoms[name]}");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The {name} virus is unknown");
            //    }
            //}

            //// ----------------------------------------------------------------------------------------------------
            //// Queues/Stacks
            //// ----------------------------------------------------------------------------------------------------
            //var diseasesToCure = new Queue<string>(); //queues are FIFO

            //diseasesToCure.Enqueue("SARS");
            //diseasesToCure.Enqueue("COVID-19");
            //diseasesToCure.Enqueue("polio");

            //diseasesToCure.Dequeue(); // removes first index

            //var moreDiseasesToCure = new Stack<string>(); //stacks are LILO

            //moreDiseasesToCure.Push("SARS");
            //moreDiseasesToCure.Push("COVID-19");
            //moreDiseasesToCure.Push("polio");

            //moreDiseasesToCure.Pop(); // removes last index

            //// ----------------------------------------------------------------------------------------------------
            //// Hashset
            //// ----------------------------------------------------------------------------------------------------
            //var vectors = new HashSet<string>(); // good for comparing data

            //vectors.Add("airborne"); // only stores one copy of each entry and ignores duplicate entries
            //vectors.Add("airborne");
            //vectors.Add("airborne");
            //vectors.Add("airborne");
            //vectors.Add("airborne");
            //vectors.Add("airborne");
            //vectors.Add("airborne");
            //vectors.Add("droplet");
            //vectors.Add("droplet");
            //vectors.Add("droplet");
            //vectors.Add("droplet");
            //vectors.Add("bloodborne");
            //vectors.Add("bloodborne");
            //vectors.Add("bloodborne");


            Console.ReadKey();

        }
    }
}
