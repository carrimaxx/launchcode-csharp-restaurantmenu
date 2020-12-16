using System;
using System.Collections.Generic;

namespace Class3Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            var iceCream = new MenuItem("Ice Cream", 2.50, "Vanilla ice cream", "dessert", false);
            var spaghetti = new MenuItem("Spaghetti", 4.99, "Spaghetti with meatballs", "Main Course", false);
            // below will fail to add due to Equals override
            var spaghetti2 = new MenuItem("Spaghetti", 4.29, "Spaghetti with meatballs", "Main Course", false);
            var hawaiianPizza = new MenuItem("Hawaiian Pizza", 1.99, "Pizza with pineapple chunks, ham, and bacon", "main course", false);
            var bruschetta = new MenuItem("Bruschetta", 3, "Toasted bread slices with tomatoes", "Appetizer", true);

            var menu = new Menu();
            menu.AddMenuItem(iceCream);
            menu.AddMenuItem(spaghetti);
            menu.AddMenuItem(spaghetti2);
            menu.AddMenuItem(hawaiianPizza);
            menu.AddMenuItem(bruschetta);

            Console.WriteLine("Print the menu:");
            menu.PrintMenu(menu.MenuItems);

            Console.WriteLine("\nPrint a menu item:");
            menu.PrintItem(bruschetta);
        }
    }
}
