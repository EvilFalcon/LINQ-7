using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        public static void Main()
        {
            List<Soldier> firstTeam = new List<Soldier>()
            {
                new Soldier("Бежин В.В"),
                new Soldier("Бакин В.В"),
                new Soldier("Барышников К.К"),
                new Soldier("Бабушкин А.В"),
                new Soldier("Воронин К.Д"),
                new Soldier("Воронин К.Д"),
                new Soldier("Дима"),
                new Soldier("Дима"),
            };

            List<Soldier> secondTeam = new List<Soldier>()
            {
                new Soldier("Бажин В.В"),
                new Soldier("Бажин В.Ю"),
                new Soldier("Барышников Б.К"),
                new Soldier("Бабушкин Д.В"),
            };

            List<Soldier> temporaryTeam =
                firstTeam.Where(soldier => soldier.Name.ToLower().Trim().StartsWith("б")).ToList();
            firstTeam = firstTeam.Except(temporaryTeam).ToList();
            secondTeam = secondTeam.Union(temporaryTeam).ToList();

            SoldersInfo(firstTeam);

            Console.WriteLine(new string('_', 40));

            SoldersInfo(secondTeam);

            Console.ReadKey();
        }

        public static void SoldersInfo(List<Soldier> solders)
        {
            foreach (var soldier in solders)
            {
                Console.WriteLine(soldier.Name);
            }
        }
    }

    public class Soldier
    {
        public Soldier(string name)
        {
            Name = name;
        }

        public string Name { get; }
    }
}