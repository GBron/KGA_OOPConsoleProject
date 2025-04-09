using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Monsters
{
    public class BossFactory
    {
        Monster Monster;

        public Monster Create(BossList name)
        {
            switch (name)
            {
                case BossList.고블린족장:
                    Monster = new Monster("고블린 족장", 350, 35, 15, 100, 1000);
                    break;
                case BossList.오크전사:
                    Monster = new Monster("오크 전사", 600, 50, 25, 300, 2500);
                    break;
                case BossList.오크족장:
                    Monster = new Monster("오크 족장", 1000, 75, 35, 700, 4000);
                    break;
                case BossList.메탈슬라임:
                    Monster = new Monster("메탈 슬라임", 1500, 50, 75, 1000, 7500);
                    break;
                case BossList.트롤:
                    Monster = new Monster("트롤", 2500, 125, 45, 1500, 12000);
                    break;
                case BossList.드래곤:
                    Monster = new Monster("드래곤", 3500, 150, 55, 2500, 15000);
                    break;
                case BossList.마왕:
                    Monster = new Monster("마왕", 5000, 200, 75, 0, 0);
                    break;
            }
            return Monster;
        }
    }
}
