using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        public static void Main()
        {
            List<Soldier> first = new List<Soldier>()
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

            List<Soldier> second = new List<Soldier>()
            {
                new Soldier("Бажин В.В"),
                new Soldier("Бажин В.Ю"),
                new Soldier("Барышников Б.К"),
                new Soldier("Бабушкин Д.В"),
            };

            var TMP = first.Where(soldier => soldier.Name.ToLower().Trim().StartsWith("б"));
            first = first.Except(TMP).ToList();
            second = second.Union(TMP).ToList();

            SoldersInfo(first);

            Console.WriteLine(new string('_', 40));

            SoldersInfo(second);

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