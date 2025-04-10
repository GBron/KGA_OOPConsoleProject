using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item.UsableItem
{
    public class PotionFactory
    {
        Potion potion;

        public Potion Create(PotionList name)
        {
            switch(name)
            {
                case PotionList.소형회복포션:
                    potion = new Potion("소형 회복 포션", 25, 100, "작은 회복 포션, 체력을 25 회복시킨다.");
                    break;
                    case PotionList.회복포션:
                    potion = new Potion("회복 포션", 50, 200, "일반적인 회복 포션, 체력을 50 회복시킨다.");
                    break;
                case PotionList.대형회복포션:
                    potion = new Potion("대형 회복 포션", 100, 500, "대형 회복 포션, 체력을 100 회복시킨다.");
                    break;
                case PotionList.특대형회복포션:
                    potion = new Potion("특대형 회복 포션", 300, 1500, "특대형 회복 포션, 체력을 300 회복시킨다.");
                    break;
            }

            return potion;
        }
    }
}
