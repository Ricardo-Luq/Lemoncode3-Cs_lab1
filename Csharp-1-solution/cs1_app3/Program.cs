using System;

namespace cs1_app3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.WriteLine("[3. Weekend teller]");
            Console.WriteLine("Write the name of a day of the week");
            string weekday = Console.ReadLine().ToLower();
            string response = weekday == "saturday" || weekday == "sunday" ?
                "It's a weekend day." : "It's not part of the weekend";
            Console.WriteLine(response);
            } catch (Exception e) { 
                Console.WriteLine("The following error happened:");
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();

        }
    }
}
