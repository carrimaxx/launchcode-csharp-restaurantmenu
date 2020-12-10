using System;
using System.Collections.Generic;

namespace Class3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            var menu = new Menu();
            menu.AddMenuItem(new MenuItem("Ice Cream", 2.50, "Vanilla ice cream", "dessert", false));
            menu.AddMenuItem(new MenuItem("Spaghetti", 4.99, "Spaghetti with meatballs", "Main Course", false));
            // below will fail to add due to Equals override
            menu.AddMenuItem(new MenuItem("Spaghetti", 4.29, "Spaghetti with meatballs", "Main Course", false));
            menu.AddMenuItem(new MenuItem("Hawaiian Pizza", 1.99, "Pizza with pineapple chunks, ham, and bacon", "main course", false));
            menu.AddMenuItem(new MenuItem("Bruschetta", 3, "Toasted bread slices with tomatoes", "Appetizer", true));

            Console.WriteLine("Print the menu:");
            Menu.PrintMenu(menu.MenuItems);

            Console.WriteLine("\nPrint a menu item:");
            Menu.PrintItem(new MenuItem("Bruschetta", 3, "Toasted bread slices with tomatoes", "Appetizer", true));
        }
    }
}
