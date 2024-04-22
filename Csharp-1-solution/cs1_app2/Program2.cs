using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs1_app1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[2. Number comparator]");
            bool success;
            do
            {
                success = true;
                try
                {
                    Console.WriteLine("Input a number:");
                    int num1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Input the number you wish to compare it with:");
                    int num2 = int.Parse(Console.ReadLine());
                    string response = num1 == num2 ?
                        "They are equal." : num1 > num2 ?
                            "The first number is greater" : "The second number is greater.";
                    Console.WriteLine(response);

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
