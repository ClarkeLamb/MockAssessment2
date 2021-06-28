using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockAssessment2a
{
    class Challenge
    {
        public string Character { get; set; }
        public int AttackValue { get; set; }
        public string Planets { get; set; }

        public Challenge()
        {

        }
        public Challenge(string character, int attackValue)
        {
            Character = character;
            AttackValue = attackValue;
        }

        public static string AddStarWarsCharacters(string userInput)
        {
            if(userInput == "Yoda")
            {
                return "Yoda";
            }
            return "";
        } 

        public void DeathStarCombat(Dictionary<string, int>deathStar)
        {
            foreach(KeyValuePair<string, int>characterInfo in deathStar)
            {
                if (characterInfo.Value.Equals(99))
                {
                    Console.WriteLine($"{characterInfo.Key}, is the Jedi with highest attack value.");
                }
            }
        }

        public void ConvertPlanets(string[] planets)
        {
            List<string> planetList = planets.Reverse().ToList();
            foreach (var i in planetList)
            {
                Console.WriteLine(i);
            }
            
        }

        public void AverageDroids(List<double> droid)
        {
            double average = 0;
            List<double> evenDroids = new List<double>();
            evenDroids.Add(12);
            evenDroids.Add(212);

            foreach (double evenBot in evenDroids)
            {
                average = evenDroids.Average();
                
            }
            Console.WriteLine(average);

           
        }

        public static void TryToCatchDarthVader(string userInputTwo)
        {
            try
            {
                int number = int.Parse(userInputTwo);

                Console.WriteLine("Vader was captured!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Vader got awat!");

            }
        }

        //public static string TryToCatchDarthVader(string userInputTwo)
        //{
        //    try
        //    {
        //        int answer = int.Parse(userInputTwo);
        //        return "Vader was Captured!";
        //    }
        //    catch (FormatException ex)
        //    {
        //        return $"(Error: {ex})";

        //    }




    }
}
