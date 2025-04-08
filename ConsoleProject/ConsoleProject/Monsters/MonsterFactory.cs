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

        private float rate = 1;

        public Monster Create(MonsterList name)
        {
            switch (name)
            {
                case MonsterList.슬라임:
                    Monster = new Monster("슬라임", (int)(50*rate), (int)(10*rate), (int)(0*rate), (int)(10 * rate), (int)(50 * rate));
                    break;
                case MonsterList.고블린:
                    Monster = new Monster("고블린", (int)(100 * rate), (int)(10 * rate), (int)(3 * rate), (int)(20 * rate), (int)(100 * rate));
                    break;
                case MonsterList.코볼트:
                    Monster = new Monster("코볼트", (int)(150 * rate), (int)(15 * rate), (int)(5 * rate), (int)(30 * rate), (int)(150 * rate));
                    break;
                case MonsterList.오크:
                    Monster = new Monster("오크", (int)(200 * rate), (int)(20 * rate), (int)(10 * rate), (int)(50 * rate), (int)(200 * rate));
                    break;
            }
            return Monster;
        }
    }
}
