using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class DeadScene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Util.PrintLine("");
            Util.PrintLine("");
            Util.PrintLine("");
            Util.PrintLine("                      YOU DIED                       ", ConsoleColor.DarkRed);
            Util.PrintLine("");
            Util.PrintLine("             하지만 죽음은 끝이 아닙니다.            ", ConsoleColor.DarkGray);
            Util.PrintLine("");
            Util.PrintLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }

        public override void Select()
        {
            Util.PrintLine("                1. 마을에서 부활");
            Util.PrintLine("                2. 종료");
        }

        public override void Reaction()
        {
        }

        public override void Wait()
        {
        }

        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.ChangeScene("Town");
                    GameManager.player.Hp = GameManager.player.MaxHp;
                    GameManager.player.Gold = GameManager.player.Gold/2;
                    GameManager.player.Exp = GameManager.player.Exp/2;
                    break;
                case ConsoleKey.D2:
                    GameManager.Exit();
                    break;
            }
        }
    }
}
