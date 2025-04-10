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
                    armor = new Armor("천 갑옷", 3, 1500, "방어능력은 부실하다.");
                    break;
                case ArmorList.가죽갑옷:
                    armor = new Armor("가죽 갑옷", 8, 4000, "이제야 뭘 좀 입은 느낌이 난다.");
                    break;
                case ArmorList.사슬갑옷:
                    armor = new Armor("사슬 갑옷", 15, 7500, "드디어 방어력이 체감이 된다.");
                    break;
                    case ArmorList.판금갑옷:
                    armor = new Armor("판금 갑옷", 20, 10000, "이제야 진짜 갑옷을 입은 느낌이 든다.");
                    break;
                case ArmorList.미스릴판금갑옷:
                    armor = new Armor("미스릴 갑옷", 35, 20000, "웬만한 칼로는 흠집도 안난다.");
                    break;
                case ArmorList.아다만티움판금갑옷:
                    armor = new Armor("아다만티움 갑옷", 50, 30000, "용의 불길도 견뎌낸다는 강력한 갑옷.");
                    break;
                case ArmorList.없음:
                    armor = new Armor("없음", 0, 0, "당신은 갑옷을 착용하지 않다.");
                    break;
            }
            return armor;
        }
    }
}
