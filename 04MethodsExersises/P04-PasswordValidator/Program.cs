using System;

namespace P04_PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isBetweenSixAndTenChars = CheckStringLength(password);
            bool isOnlyLettersAndDigits = CheckOnlyForLettersAndDigits(password);
            bool hasAtLeastTwoDigits = CheckIfHasAtLeastTwoDigits(password);

            if (!isBetweenSixAndTenChars)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }

            if (!isOnlyLettersAndDigits)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }

            if (!hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isBetweenSixAndTenChars && 
                isOnlyLettersAndDigits && 
                hasAtLeastTwoDigits)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool CheckIfHasAtLeastTwoDigits(string password)
        {
            int counter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsDigit(password[i]))
                {
                    counter++;
                }
            }

            if (counter >= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private static bool CheckOnlyForLettersAndDigits(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (!char.IsLetterOrDigit(password[i]))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CheckStringLength(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
