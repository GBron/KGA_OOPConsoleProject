using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class Innscene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("여관에 도착했습니다.");
            Util.PrintLine("여관은 아늑하게 꾸며져 있습니다.");
        }
        public override void Select()
        {
            Util.Print("1. 휴식하기 ");
            Util.Print("[ 체력 회복 ]", ConsoleColor.Red);
            Util.PrintLine("100 G", ConsoleColor.DarkYellow);
            Util.PrintLine("2. 나가기");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    if (GameManager.player.Gold < 100)
                    {
                        Util.PrintLine("돈이 부족합니다.");
                        return;
                    }
                    Util.Print("휴식 합니다...");
                    Util.PrintLine("[ 체력 전부 회복! ]", ConsoleColor.Green);
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("방에서 나갑니다.");
                    break;
            }
        }
        public override void Wait()
        {

        }

        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    if (GameManager.player.Gold < 100)
                    {
                        Util.PrintLine("돈이 부족합니다.");
                        return;
                    }
                    GameManager.player.Hp = GameManager.player.MaxExp;
                    GameManager.player.Gold -= 100;
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("Town");
                    break;
            }
        }
    }
}
