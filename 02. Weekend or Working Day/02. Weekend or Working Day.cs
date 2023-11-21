using System;
namespace _02._Weekend_or_Working_Day
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            
            if (input == "Monday") { Console.WriteLine("Working day"); }
            else if (input == "Tuesday") { Console.WriteLine("Working day"); }
            else if (input == "Wednesday") { Console.WriteLine("Working day"); }
            else if (input == "Thursday") { Console.WriteLine("Working day"); }
            else if (input == "Friday") { Console.WriteLine("Working day"); }
            else if (input == "Saturday") { Console.WriteLine("Weekend"); }
            else if (input == "Sunday") { Console.WriteLine("Weekend"); }
            else  
            { Console.WriteLine("Error"); }


        }
    }
}