using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item.UsableItem
{
    public class UsableItem : IItem, IUsable
    {
        protected string name;
        public string Name { get { return name; } set { name = value; } }

        protected int price;
        public int Price { get { return price; } set { price = value; } }

        protected string description;
        public string Desc { get { return description; } set { description = value; } }

        public virtual void Use()
        {

        }
    }
}
