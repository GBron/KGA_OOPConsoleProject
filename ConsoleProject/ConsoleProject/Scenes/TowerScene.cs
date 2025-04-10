using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    
    public class TowerScene : Scene
    {
        

        public override void MainScene()
        {
            Util.PrintLine("     ＼                                      ／         ");
            Util.PrintLine("       ＼ ＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿＿ ／         ");
            Util.PrintLine("         |                                |           ");
            if (GameManager.towerFloor == 7)
            {
                Util.PrintLine("         |                                |           ");
                Util.PrintLine("         |                                |           ");
                Util.PrintLine("         |               ,_,              |           ");
                Util.PrintLine("         |            __(___)__           |           ");
                Util.PrintLine("         |            /  \\'/  \\           |           ");
                Util.PrintLine("         |           |    ^    |          |           ");
            }
            else
            {
                Util.PrintLine("         |           ＿＿＿＿＿           |           ");
                Util.PrintLine("         |          / /______\\ \\          |           ");
                Util.PrintLine("         |         | /________\\ |         |           ");
                Util.PrintLine("         |         |/___(￣)___\\|         |           ");
                Util.PrintLine("         |         |___|'￣'|___|         |           ");
                Util.PrintLine("         |         |   |    |   |         |           ");
            }
            Util.PrintLine("");
            if (GameManager.towerFloor == 0)
                GameManager.towerFloor = 1;

            if (GameManager.towerFloor != 1)
            {
                Util.PrintLine($"{GameManager.towerFloor}층에 도착했습니다.");
            }
            else
                Util.PrintLine("탑에 들어왔습니다.");
            Util.PrintLine("눈 앞에 강력한 적이 보입니다...!!");
            Util.PrintLine("[주의] 강력한 적과의 전투에선 도망 칠 수 없습니다!", ConsoleColor.Yellow);
        }

        public override void Select()
        {
            Util.PrintLine("1. 강력한 적과 전투");
            Util.PrintLine("0. 나가기");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("적과 전투합니다..!", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D0:
                    Util.PrintLine("밖으로 나갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.I:
                    GameManager.inventory.Open();
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
                    GameManager.ChangeScene("BossBattle");
                    GameManager.ChangeBoss((Monsters.BossList)GameManager.towerFloor);
                    break;
                case ConsoleKey.D0:
                    GameManager.ChangeScene("Field");
                    break;

            }
        }
    }
}
