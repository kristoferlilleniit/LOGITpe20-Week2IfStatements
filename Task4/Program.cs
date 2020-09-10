using System;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number;
            string UserInput;
            Console.WriteLine("Insert a number.");
            UserInput = Console.ReadLine();
            Number = Int32.Parse(UserInput);

            if(Number < 0)
            {
                Console.WriteLine("The number is negative.");
            }
            else if(Number > 0)
            {
                Console.WriteLine("The number is positive.");
            }
            else
            {
                Console.WriteLine("The number is 0.");
            }
        }
    }
}
