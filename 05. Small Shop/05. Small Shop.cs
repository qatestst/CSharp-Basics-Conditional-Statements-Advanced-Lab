namespace _05._Small_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string productName = Console.ReadLine();
            string city = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            double price = 0;

            if (productName == "coffee" && city == "Sofia") { price = 0.50; }
            else if (productName == "coffee" && city == "Plovdiv") { price = 0.40; }
            else if (productName == "coffee" && city == "Varna") { price = 0.45; }

            else if (productName == "water" && city == "Sofia") { price = 0.80; }
            else if (productName == "water" && city == "Plovdiv") { price = 0.70; }
            else if (productName == "water" && city == "Varna") { price = 0.70; }

            else if (productName == "beer" && city == "Sofia") { price = 1.20; }
            else if (productName == "beer" && city == "Plovdiv") { price = 1.15; }
            else if (productName == "beer" && city == "Varna") { price = 1.10; }

            else if (productName == "sweets" && city == "Sofia") { price = 1.45; }
            else if (productName == "sweets" && city == "Plovdiv") { price = 1.30; }
            else if (productName == "sweets" && city == "Varna") { price = 1.35; }

            else if (productName == "peanuts" && city == "Sofia") { price = 1.60; }
            else if (productName == "peanuts" && city == "Plovdiv") { price = 1.50; }
            else if (productName == "peanuts" && city == "Varna") { price = 1.55; }

            Console.WriteLine(price*quantity);

        }
    }
}