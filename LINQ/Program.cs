using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Program
    {
        public static void Main()
        {
            List<Soldier> soldiers = new List<Soldier>()
            {
                new Soldier("Бажин В.В"),
                new Soldier("Барышников Б.К"),
                new Soldier("Бабушкин Д.В"),
                new Soldier("Воронин К.Д"),
                new Soldier("Дима"),
            };

            var first = soldiers.Where(soldier => soldier.Name.ToLower().Trim().StartsWith("б"));

            foreach (var soldier in first)
            {
                Console.WriteLine(soldier.Name);
            }

            Console.ReadKey();
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