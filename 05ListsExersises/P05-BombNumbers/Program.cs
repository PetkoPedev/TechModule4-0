using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombTokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombNum = bombTokens[0];
            int bombStrength = bombTokens[1];

            for (int i = 0; i < list.Count; i++)
            {
                int currentNumber = list[i];
                if (currentNumber == bombNum)
                {
                    var leftIndex = Math.Max(i - bombStrength, 0);
                    var rightIndex = Math.Min(i + bombStrength, list.Count - 1);

                    var removeCount = rightIndex - leftIndex + 1;

                    list.RemoveRange(leftIndex, removeCount);
                    i = -1;
                }
            }
            Console.WriteLine(list.Sum());
        }
    }
}
