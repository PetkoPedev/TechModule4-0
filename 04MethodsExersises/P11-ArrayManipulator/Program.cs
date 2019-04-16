using System;
using System.Linq;

namespace P11_ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            string[] input = Console.ReadLine().Split();
            string command = input[0];
            while (command != "end")
            {
                switch (command)
                {
                    case "exchange":
                        int index = int.Parse(input[1]);
                        Exchange(inputArray, index);
                        break;
                    case "max":
                        break;
                    case "min":
                        break;
                    case "first":
                        break;
                    case "last":
                        break;

                    default:
                        break;
                }

                command = Console.ReadLine();
            }
        }

        static void Exchange(int[] inputArray, int index)
        {
            throw new NotImplementedException();
        }
    }
}
