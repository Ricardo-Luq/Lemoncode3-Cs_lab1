using System;
using System.Linq;

namespace cs1_app6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[6. Triangle generator]");
            bool success;
            do
            {
                success = true;
                try
                {
                    
                    Console.WriteLine("Write the pyramid's size:");
                    int height = int.Parse(Console.ReadLine());
                    Console.WriteLine("Write the character used for it");
                    char baseChar = Console.ReadLine().ElementAt(0);
                    Console.WriteLine("");
                    for (int length = 0; length < height; length++)
                    {
                        if (length != 0) //Writes the inital character, respecting smaller sizes like 1 or 2
                        { 
                        Console.Write(baseChar);
                        }

                        if (length != height-1) //Writes the main diagonal
                        {
                            for (int j = 0; j < (length-1); j++)
                            {
                                Console.Write(" ");
                            }
                            Console.Write(baseChar);
                        } 
                        else
                        {
                            for (int j = 1; j < length; j++) //Draws the triangle's base
                            {
                                Console.Write(baseChar);
                            }
                            Console.Write(baseChar);

                        }
                        Console.Write("\n");
                    }


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
