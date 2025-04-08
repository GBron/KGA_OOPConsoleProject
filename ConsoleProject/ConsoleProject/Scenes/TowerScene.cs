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
            Util.PrintLine("탑에 도착했습니다.");
            Util.PrintLine("탑은 신비로운 분위기로 가득 차 있습니다.");
        }

        public override void Select()
        {
            Util.PrintLine("1. 탑으로 들어간다");
            Util.PrintLine("2. 나가기");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("탑으로 들어갑니다.");
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("밖으로 나갑니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Util.PrintLine("아무키나 눌러주세요.", ConsoleColor.DarkGray);
            Console.ReadKey(true);
        }

        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("Field");
                    break;
            }
        }
    }
}
