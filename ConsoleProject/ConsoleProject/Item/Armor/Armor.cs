using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item.Armor
{
    public class Armor : IItem, IEquipable
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int defense;
        public int Defense { get { return defense; } set { defense = value; } }

        private int price;
        public int Price { get { return price; } set { price = value; } }

        private string description;
        public string Desc { get { return description; } set { description = value; } }

        public Armor(string name, int defense, int price, string desc)
        {
            this.Name = name;
            this.Defense = defense;
            this.Price = price;
            this.Desc = desc;
        }
    }
}
