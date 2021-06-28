using System;
using System.Collections.Generic;

namespace MockAssessment2a
{
    class Program
    {
        static void Main(string[] args)
        {
            //var yoda = new Challenge("Yoda", 99);
            //var kenobi = new Challenge("Obi-Wan Kenobi", 82);
            //var lukeSkywalker = new Challenge("Luke Skywalker", 88);
            //var anakin = new Challenge("Anakin Skywalker", 97);
            //var windu = new Challenge("Mace Windu", 80);

            //#2
            Dictionary<string, int> deathStar = new Dictionary<string, int>();
            deathStar.Add("Yoda", 99);
            deathStar.Add("Obi-Wan Kenobi", 82);
            deathStar.Add("Luke Skywalker", 88);
            deathStar.Add("Anakin Skywalker", 97);
            deathStar.Add("Mace Windu", 80);

            var stepTwo = new Challenge();
            stepTwo.DeathStarCombat(deathStar);

            //#3
            string[] planets = { "Naboo", "Tatooine", "Hoth", "Mustafar" };

            var stepThree = new Challenge();
            stepThree.ConvertPlanets(planets);

            //#4
            List<double> droid = new List<double>();
            droid.Add(12);
            droid.Add(67);
            droid.Add(212);
            droid.Add(55);

            var stepFour = new Challenge();
            stepFour.AverageDroids(droid);

            //#5
            Console.WriteLine("Was 1,2,3,4,5 or 6 your favorite star wars movie?");
            string userInputTwo = Console.ReadLine();
            TryToCatchDarthVader(userInputTwo);


        }

        //public static void TryToCatchDarthVader(string userInputTwo)
        //{
        //    try
        //    {
        //        int number = int.Parse(userInputTwo);

        //        Console.WriteLine("Vader was captured!");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("Vader got awat!");

        //    }
        //}

    }
}