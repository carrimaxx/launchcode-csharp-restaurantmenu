using System;
using System.Collections.Generic;
using System.Text;

namespace Class3Studio
{
    public class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool IsNew { get; set; }
        public string Category { get; set; }
        

        public MenuItem(string name, double price, string description, string category, bool isNew)
        {
            Name = name;
            Price = price;
            Description = description;
            Category = category;
            IsNew = isNew;
        }

        public override string ToString()
        {
            var newText = "";
            if (IsNew)
            {
                newText = "New!";
            }
            return String.Format($"{Name} - ${Price}, {Description}, {Category}  {newText}");
        }

        public override bool Equals(Object obj)
        {
            if (this == obj)
            {
                return true;
            }
            if (obj == null)
            {
                return false;
            }

            MenuItem menuItem = obj as MenuItem;
            return Name == menuItem.Name && Category == menuItem.Category;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name, Category);
        }
    }
}
