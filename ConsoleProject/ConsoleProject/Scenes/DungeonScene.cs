using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    // 미로 구현 후 사용
    public class DungeonScene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("던전으로 들어갑니다.");
            Util.PrintLine("어두운 던전입니다.");
        }

        public override void Select()
        {
            Util.PrintLine("1. 던전 탐험");
            Util.PrintLine("2. 나가기");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("던전을 탐험합니다.");
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