using System;
using System.Linq;

namespace P10_LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var fieldSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Where(a => a >= 0 && a < fieldSize)
                .ToArray();

            var ladybugs = new int[fieldSize];

            foreach (var ladybugIndex in ladybugIndexes)
            {
                ladybugs[ladybugIndex] = 1;
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "end")
                {
                    break;
                }

                var tokens = input.Split();
                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var count = int.Parse(tokens[2]);

                var isInsideArray = ladybugIndex >= 0 && ladybugIndex < ladybugs.Length;
                if (!isInsideArray)
                {
                    continue;
                }

                var ladybugExists = ladybugs[ladybugIndex] == 1;
                if (!ladybugExists)
                {
                    continue;
                }

                MoveLadybug(ladybugs, ladybugIndex, direction, count);
                
            }
            Console.WriteLine(String.Join(" ", ladybugs));
        }

        static void MoveLadybug(int[] ladybugs, int ladybugIndex, string direction, int count)
        {
            if (direction == "left")
            {
                count = -count;
                var nextIndex = ladybugIndex + count;
                ladybugs[ladybugIndex] = 0;

                var hasLeftArrayOrFoundPlace = false;
                while (!hasLeftArrayOrFoundPlace)
                {
                    if (nextIndex < 0 || nextIndex > ladybugs.Length - 1)
                    {
                        hasLeftArrayOrFoundPlace = true;
                        continue;
                    }

                    var ladybugAlreadyExistsOnIndex = ladybugs[nextIndex] == 1;
                    if (ladybugAlreadyExistsOnIndex)
                    {
                        nextIndex += count;
                        continue;
                    }
                    ladybugs[nextIndex] = 1;
                    hasLeftArrayOrFoundPlace = true;
                }
            }
        }
    }
}
