using System;

namespace SomeConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BilkaTwo!");
            Console.WriteLine("You are at " + Inventory.Name + "Category");
            Console.WriteLine("(A) Get all items from this category");
            Console.WriteLine("(B) Get all items from this category including subcategories");
            Console.WriteLine("(C) Choose from a list subcategories");
        }
    }
}
