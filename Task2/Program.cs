using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your year of birth?");
            string UserInput;
            UserInput = Console.ReadLine();
            int YearOfBirth;
            // parsing string to interger (number)
            YearOfBirth = Int32.Parse(UserInput);
            int Age = 2020 - YearOfBirth;
            if (Age < 18)

                Console.WriteLine($"you are {Age}, you are too young. ");
            else if (Age > 18)

                Console.WriteLine($"you are {Age} old enough to get permanent driving licence.");
        }
    }
}
