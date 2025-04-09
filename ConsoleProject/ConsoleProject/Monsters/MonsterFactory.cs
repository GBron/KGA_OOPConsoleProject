using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Monsters
{
    public class MonsterFactory
    {
        Monster Monster;

        private float rate = GameManager.towerFloor == 0 ? 1 : 1 * (float)(GameManager.towerFloor/5f);

        public Monster Create(MonsterList name)
        {
            switch (name)
            {
                case MonsterList.슬라임:
                    Monster = new Monster("슬라임", (int)(50*rate), (int)(10*rate), (int)(0*rate), (int)(10 * (rate * 1.5f)), (int)(50 * (rate * 1.5f)));
                    break;
                case MonsterList.고블린:
                    Monster = new Monster("고블린", (int)(100 * rate), (int)(10 * rate), (int)(3 * rate), (int)(20 * (rate * 1.5f)), (int)(100 * (rate * 1.5f)));
                    break;
                case MonsterList.코볼트:
                    Monster = new Monster("코볼트", (int)(150 * rate), (int)(15 * rate), (int)(5 * rate), (int)(30 * (rate * 1.5f)), (int)(150 * (rate * 1.5f)));
                    break;
                case MonsterList.오크:
                    Monster = new Monster("오크", (int)(200 * rate), (int)(20 * rate), (int)(10 * rate), (int)(50 * (rate * 1.5f)), (int)(200 * (rate * 1.5f)));
                    break;
            }
            return Monster;
        }
    }
}
