using System;

namespace P05_Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = "";

            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            string currentPassword = Console.ReadLine();

            int invalidPasswordAttempt = 0;
            while (currentPassword != password)
            {
                invalidPasswordAttempt+=1;

                if (invalidPasswordAttempt == 4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                currentPassword = Console.ReadLine();
            }

            if (invalidPasswordAttempt < 4)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
