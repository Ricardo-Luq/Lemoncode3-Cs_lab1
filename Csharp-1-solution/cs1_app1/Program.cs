using System;

namespace test_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1. Greeting machine]");
            bool success;
            do
            {
                success = true;
                try
                {
                    Console.WriteLine("Please input your name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Now input your age:");
                    int age = int.Parse(Console.ReadLine());
                    Console.WriteLine("Finally input a city name:");
                    string city = Console.ReadLine();
                    Console.WriteLine($"Your name is {name} and you are {age} years old. Welcome to {city}.");
                }
                catch (Exception) //Extremely generic catch, but it works for a simple exercise like this
                {
                    Console.WriteLine("You have introduced an incorrect value. Please follow the instructions.");
                    success = false;
                }
            } while (!success);
            Console.ReadLine();
        }
    }
}
