using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_ListManipulationAdvanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end")
                {
                    break;
                }

                string[] tokens = line.Split();

                switch (tokens[0])
                {
                    case "Contains":
                        int containedNumber = int.Parse(tokens[1]);
                        if (numbers.Contains(containedNumber))
                        {
                            Console.WriteLine("Yes");
                        }
                        else
                        {
                            Console.WriteLine("No such number");
                        }
                        break;
                    case "PrintEven":
                        List<int> resultEven = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 0)
                            {
                                resultEven.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", resultEven));
                        break;
                    case "PrintOdd":
                        List<int> resultOdd = new List<int>();
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] % 2 == 1)
                            {
                                resultOdd.Add(numbers[i]);
                            }
                        }
                        Console.WriteLine(string.Join(" ", resultOdd));
                        break;
                    case "GetSum":
                        int sum = numbers.Sum();
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = tokens[1];
                        int number = int.Parse(tokens[2]);
                        List<int> filteredResult = new List<int>();
                        if (condition == "<")
                        {

                            //for (int i = 0; i < numbers.Count; i++)
                            //{
                            //    if (numbers[i] < number)
                            //    {
                            //        filteredResult.Add(numbers[i]);
                            //    }
                            //}
                            Console.WriteLine(string.Join(" ", filteredResult));
                        }
                        else if(condition == ">")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] > number)
                                {
                                    filteredResult.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredResult));
                        }
                        else if(condition == ">=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] >= number)
                                {
                                    filteredResult.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredResult));
                        }
                        else if(condition == "<=")
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                if (numbers[i] <= number)
                                {
                                    filteredResult.Add(numbers[i]);
                                }
                            }
                            Console.WriteLine(string.Join(" ", filteredResult));
                        }
                        break;
                }
            }
        }
    }
}
