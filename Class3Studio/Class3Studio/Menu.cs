using System;
using System.Collections.Generic;
using System.Text;

namespace Class3Studio
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }
        public DateTime LastUpdated { get; private set; }


        public Menu()
        {
            MenuItems = new List<MenuItem>();
        }

        public void AddMenuItem(MenuItem menuItem)
        {
            if (!MenuItems.Contains(menuItem))
            {
                MenuItems.Add(menuItem);
                LastUpdated = DateTime.Now;
            }
        }

        public void RemoveMenuItem(MenuItem menuItem)
        {
            MenuItems.Remove(menuItem);
            LastUpdated = DateTime.Now;
        }

        public override string ToString()
        {
            string menuString = String.Format("Last Update ({0}):{1}", LastUpdated, Environment.NewLine);
            foreach (var menuItem in MenuItems)
            {
                menuString = menuString + menuItem.ToString() + Environment.NewLine;
            }
            return menuString;
        }

        public void PrintMenu(List<MenuItem> menu)
        {
            foreach (object item in menu)
            {
                Console.WriteLine(item);
            }
        }
        public void PrintItem(MenuItem item)
        {
            Console.WriteLine($"{ item.Name } - ${ item.Price}, { item.Description}, {item.Category}, {item.IsNew}");
        }

    }
}
