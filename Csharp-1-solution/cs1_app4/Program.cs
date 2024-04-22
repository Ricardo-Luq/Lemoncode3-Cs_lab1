using System;

namespace cs1_app4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[4. even number counter]");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.Write(i + " ");
                if (i % 10 == 0)
                {
                    Console.Write("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
