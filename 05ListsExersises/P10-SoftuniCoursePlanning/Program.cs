using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_SoftuniCoursePlanning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> scheduleOfLessons = Console.ReadLine().Split(", ").ToList();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "course start")
            {
                string[] tokens = input.Split(':').ToArray();
                string command = tokens[0];

                switch (command)
                {
                    case "Add":
                        string lessonToAdd = tokens[1];
                        scheduleOfLessons.Add(lessonToAdd);
                        break;
                    case "Insert":
                        string lessonToInsert = tokens[1];
                        int index = int.Parse(tokens[2]);
                        scheduleOfLessons.Insert(index, lessonToInsert);
                        break;
                    case "Remove":
                        string lessonToRemove = tokens[1];
                        scheduleOfLessons.Remove(lessonToRemove);
                        break;
                    case "Swap":
                        string lessonTitle1 = tokens[1];
                        string lessonTitle2 = tokens[2];

                        if (scheduleOfLessons.Contains(lessonTitle1) && scheduleOfLessons.Contains(lessonTitle2))
                        {
                            int index1 = scheduleOfLessons.IndexOf(lessonTitle1);
                            int index2 = scheduleOfLessons.IndexOf(lessonTitle2);

                        }
                        break;
                    case "Exercise":
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < scheduleOfLessons.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{scheduleOfLessons[i]}");
            }
            Console.WriteLine();
        }
    }
}
