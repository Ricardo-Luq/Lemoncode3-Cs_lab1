using System;
using System.Reflection.Metadata;

namespace cs1_app5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[5. Array generator]");
            bool success;
            Random rnd = new Random();
            do
            {
                success = true;
                try
                {
                    Console.WriteLine("Input a new array's length, greater than 0:");
                    int arrLength = int.Parse(Console.ReadLine());
                    if (arrLength > 0)
                    {
                        int[] newArray = new int[arrLength]; ;
                        for (int i = 0; i < arrLength; i++)
                        {
                            newArray[i] = rnd.Next(255) ;
                        }
                        for (int i = 0; i < arrLength; i++)
                        {
                            Console.Write(newArray[i]+" ");
                            if ((i+1)%5 == 0 && i != 0)
                            {
                                Console.Write('\n');
                            }
                        }
                    }
                    else
                    {
                        throw new Exception("Array length can't be negative (nor 0 in this case)");
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
