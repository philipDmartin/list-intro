using System;
using System.Collections.Generic;

namespace list_intro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nssCohorts = new List<string>
            {
                "Cohort 36",
                "Cohort 37",
                "Cohort 38",
            };

            nssCohorts.Add("Cohort 39");

            List<int> birthYears = new List<int>
            {
                3001,
                3002,
                3003,
                3004
            };

            birthYears.Add(3005);
            birthYears.Add(3006);
            birthYears.Add(3007);
            birthYears.Add(3008);

            foreach (string cohort in nssCohorts)
            {
                Console.WriteLine(cohort);
            }

            birthYears.Remove(3001);

            foreach (int year in birthYears)
            {
                Console.WriteLine(year);

                if (year == 3000)
                {
                    Console.WriteLine("born in 3000");
                    Console.WriteLine("lets go!");
                }
            }
        }
    }
}
