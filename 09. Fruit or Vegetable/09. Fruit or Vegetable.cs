﻿namespace _09._Fruit_or_Vegetable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            switch(input) 
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "lemon":
                case "grapes":
                case "cherry":
                    Console.WriteLine("fruit"); break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":
                    Console.WriteLine("vegetable"); break;
                default: Console.WriteLine("unknown"); break;



            }
        }
    }
}