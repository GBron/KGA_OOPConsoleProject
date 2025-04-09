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
                    weapon = new Weapon("목검", 10, 1500);
                    break;
                case WeaponList.청동검:
                    weapon = new Weapon("청동검", 15, 3000);
                    break;
                case WeaponList.철검:
                    weapon = new Weapon("철검", 20, 5000);
                    break;
                case WeaponList.강철검:
                    weapon = new Weapon("강철검", 30, 10000);
                    break;
                case WeaponList.미스릴검:
                    weapon = new Weapon("미스릴검", 40, 20000);
                    break;
                case WeaponList.아다만티움검:
                    weapon = new Weapon("아다만티움검", 60, 30000);
                    break;
            }
            return weapon;
        }
    }
}
