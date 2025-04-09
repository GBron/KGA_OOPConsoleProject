using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class Tower2Scene : Scene
    {

        public override void MainScene()
        {
            GameManager.towerFloor++;
            if ( GameManager.towerFloor > 7 )
            {
                Util.PrintLine("탑을 클리어했습니다!");
                return;
            }    
            Util.PrintLine("층 보스를 물리쳤습니다!");
            Util.PrintLine("앞으로 나아가시겠습니까?");
        }

        public override void Select()
        {
            if (GameManager.towerFloor > 7)
            {
                Util.PrintLine("아무키를 눌러 계속..", ConsoleColor.DarkGray);
                return;
            }
            Util.PrintLine("1. 다음 층으로");
            Util.PrintLine("2. 나가기");
        }

        public override void Reaction()
        {
            if (GameManager.towerFloor > 7)
            {
                return;
            }

            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("다음 층으로 올라갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("밖으로 나갑니다.", ConsoleColor.White, 1500);
                    break;
            }
        }

        public override void Wait()
        {

        }

        public override void Result()
        {
            if (GameManager.towerFloor > 7)
            {
                GameManager.ChangeScene("Ending");
                GameManager.Exit();
                return;
            }

            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.ChangeScene("Tower");
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("Field");
                    break;
            }
        }
    }
}
