using System;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserInput;
            Console.WriteLine("What's your favorite animal?");
            UserInput = Console.ReadLine();

            if(UserInput == "cat")
            {
                Console.WriteLine("You are a cat person.");
            }
            else if(UserInput == "dog")
            {
                Console.WriteLine("You are a dog person.");
            }
            else
            {
                Console.WriteLine($"You are a {UserInput} person.");
            }
        }
    }
}
