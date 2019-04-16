using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            
            int n = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                }
                students[studentName].Add(grade);
            }

            foreach (var st in students.OrderByDescending(x => x.Value.Average()))
            {
                if (st.Value.Average() >= 4.50)
                {
                    Console.WriteLine($"{st.Key} -> {st.Value.Average():F2}");
                }
            }
        }
    }
}
