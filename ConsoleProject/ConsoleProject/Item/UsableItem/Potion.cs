using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item.UsableItem
{
    public class Potion : UsableItem
    {
        private int healPoint;
        public int HealPoint
        {
            get { return healPoint; }
            set { healPoint = value; }
        }

        public Potion(string name, int healingPoint, int price, string desc)
        {
            this.Name = name;
            this.HealPoint = healingPoint;
            this.Price = price;
            this.Desc = desc;
        }

        public override void Use()
        {
            GameManager.player.Heal(HealPoint);
        }
    }
}
