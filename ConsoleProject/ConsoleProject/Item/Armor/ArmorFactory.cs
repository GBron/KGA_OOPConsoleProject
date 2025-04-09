using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item.Armor
{
    public class ArmorFactory
    {
        Armor armor;

        public Armor Create(ArmorList name)
        {
            switch (name)
            {
                case ArmorList.천갑옷:
                    armor = new Armor("천 갑옷", 3, 1500);
                    break;
                case ArmorList.가죽갑옷:
                    armor = new Armor("가죽 갑옷", 8, 4000);
                    break;
                case ArmorList.사슬갑옷:
                    armor = new Armor("판금 갑옷", 15, 7500);
                    break;
                    case ArmorList.판금갑옷:
                    armor = new Armor("사슬 갑옷", 20, 10000);
                    break;
                case ArmorList.미스릴판금갑옷:
                    armor = new Armor("미스릴 판금 갑옷", 35, 20000);
                    break;
                case ArmorList.아다만티움판금갑옷:
                    armor = new Armor("아다만티움 판금 갑옷", 50, 30000);
                    break;
                case ArmorList.없음:
                    armor = new Armor("없음", 0, 0);
                    break;
            }
            return armor;
        }
    }
}
