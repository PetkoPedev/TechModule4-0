using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_LastDay
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> paintings = Console.ReadLine().Split().Select(int.Parse).ToList();

            string input;

            while ((input = Console.ReadLine()) != "END")
            {
                string[] tokens = input.Split().ToArray();

                string command = tokens[0];
                if (command == "Change")
                {
                    int paintingNumber = int.Parse(tokens[1]);
                    int numberToChange = int.Parse(tokens[2]);
                    if (paintings.Contains(paintingNumber))
                    {
                        int index = paintings.IndexOf(paintingNumber);
                        paintings.Remove(paintingNumber);
                        paintings.Insert(index, numberToChange);
                    }
                }

                if (command == "Hide")
                {
                    int paintingNumber = int.Parse(tokens[1]);
                    if (paintings.Contains(paintingNumber))
                    {
                        paintings.Remove(paintingNumber);
                    }
                }

                if (command == "Switch")
                {
                    int paintingNumber1 = int.Parse(tokens[1]);
                    int paintingNumber2 = int.Parse(tokens[2]);
                    if (paintings.Contains(paintingNumber1) && paintings.Contains(paintingNumber2))
                    {
                        int indexFirstPainting = paintings.IndexOf(paintingNumber1);
                        int indexSecondPainting = paintings.IndexOf(paintingNumber2);

                        paintings[indexFirstPainting] = paintingNumber2;
                        paintings[indexSecondPainting] = paintingNumber1;
                    }
                }

                if (command == "Insert")
                {
                    int placeIndex = int.Parse(tokens[1]);
                    int paintingNumber = int.Parse(tokens[2]);
                    if (placeIndex >= 0 && placeIndex <= paintings.Count)
                    {

                        paintings.Insert(placeIndex + 1, paintingNumber);
                    }
                }

                if (command == "Reverse")
                {
                    paintings.Reverse();
                }
            }

            Console.WriteLine(string.Join(" ", paintings));
        }
    }
}
