using System;
using System.Collections.Generic;
using System.Linq;

namespace P042_Snowwhite
{
    class Dwarf
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Physics { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var colorsToDwarf = new Dictionary<string, List<Dwarf>>();
            var allDwarfs = new List<Dwarf>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Once upon a time")
                {
                    break;
                }

                string[] dwarfInfo = line.Split(new char[] { ' ', '<', ':', '>' }, StringSplitOptions.RemoveEmptyEntries);

                string name = dwarfInfo[0];
                string color = dwarfInfo[1];
                int physics = int.Parse(dwarfInfo[2]);

                if (!colorsToDwarf.ContainsKey(color))
                {
                    colorsToDwarf[color] = new List<Dwarf>();
                }

                var dwarfsByCurrentColor = colorsToDwarf[color];
                var foundDwarf = dwarfsByCurrentColor.FirstOrDefault(d => d.Name == name);

                if (foundDwarf != null)
                {
                    foundDwarf.Physics = Math.Max(physics, foundDwarf.Physics);
                }
                else
                {
                    var dwarf = new Dwarf
                    {
                        Name = name,
                        Color = color,
                        Physics = physics
                    };

                    dwarfsByCurrentColor.Add(dwarf);
                    allDwarfs.Add(dwarf);
                }
            }

            var result = allDwarfs.OrderByDescending(d => d.Physics)
                .ThenByDescending(d => colorsToDwarf[d.Color].Count())
                .ToList();

            foreach (var dwarf in result)
            {
                Console.WriteLine($"({dwarf.Color}) {dwarf.Name} <-> {dwarf.Physics}");
            }
        }
    }
}
