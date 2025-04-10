using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Item.Weapon
{
    public class WeaponFactory
    {
        Weapon weapon;

        public Weapon Create(WeaponList weaponName)
        {
            switch (weaponName)
            {
                case WeaponList.목검:
                    weapon = new Weapon("목검", 10, 1500, "나무를 잘 깎아 만든 목검이다.");
                    break;
                case WeaponList.청동검:
                    weapon = new Weapon("청동검", 15, 3000, "청동으로 만든 검이다. 제법 날카롭다.");
                    break;
                case WeaponList.철검:
                    weapon = new Weapon("철검", 20, 5000, "표준적인 철검. 전체적으로 밸런스가 좋다.");
                    break;
                case WeaponList.강철검:
                    weapon = new Weapon("강철검", 30, 10000, "강철로 된 날카로운 검.");
                    break;
                case WeaponList.미스릴검:
                    weapon = new Weapon("미스릴검", 45, 20000, "웬만한 갑옷은 손쉽게 베어낼 수 있는 검.");
                    break;
                case WeaponList.아다만티움검:
                    weapon = new Weapon("아다만티움검", 60, 30000, "드래곤도 벨 수 있다는 강력한 검.");
                    break;
                case WeaponList.없음:
                    weapon = new Weapon("없음", 0, 0, "당신은 무기를 착용하지 않았다.");
                    break;
            }
            return weapon;
        }
    }
}
