using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber;
            int SecondNumber;
            string UserInput;
            Console.WriteLine("Insert a number.");
            UserInput = Console.ReadLine();
            FirstNumber = Int32.Parse(UserInput);
            Console.WriteLine("Insert a second number.");
            UserInput = Console.ReadLine();
            SecondNumber = Int32.Parse(UserInput);
            

            if (FirstNumber == SecondNumber)
            {
                Console.WriteLine("The two given numbers are equal.");
            }
            else
            {
                Console.WriteLine("The two given numbers aren't equal.");
            }

        }
    }
}
