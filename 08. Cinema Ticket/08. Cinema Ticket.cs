namespace _08._Cinema_Ticket
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string input = Console.ReadLine();

            if (input == "Monday") { Console.WriteLine("12"); }
            else if (input == "Tuesday") { Console.WriteLine("12"); }
            else if (input == "Wednesday") { Console.WriteLine("14"); }
            else if (input == "Thursday") { Console.WriteLine("14"); }
            else if (input == "Friday") { Console.WriteLine("12"); }
            else if (input == "Saturday") { Console.WriteLine("16"); }
            else if (input == "Sunday") { Console.WriteLine("16"); }
            
        }
    }
}