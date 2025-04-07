using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class ExplanScene : Scene
    {
        public override void MainScene()
        {
            Util.PrintCharLine("세계에 갑작스레 생겨난 마왕의 탑...", ConsoleColor.White, 50);
            Util.PrintCharLine("탑의 각 층에는 강력한 마물들이 살고있다..!", ConsoleColor.White, 50);
            Util.PrintCharLine("마물들을 물리치고 탑 최상층의 마왕을 무찌르고", ConsoleColor.White, 50);
            Util.PrintCharLine("세계에 평화를 가져오자!", ConsoleColor.White, 50);
            Console.WriteLine();
            Util.PrintLine("기본 설명", ConsoleColor.White, 500);
            Util.PrintLine("선택지가 주어졌을 땐 각 선택지에 해당하는", ConsoleColor.White, 250);
            Util.PrintLine("숫자를 입력해 선택할 수 있습니다.", ConsoleColor.White, 250);
            Util.PrintLine("맵은 마을과 던전, 탑이 있습니다.", ConsoleColor.White, 250);
            Util.PrintLine("던전은 들어갈 때 마다 구조가 바뀝니다!", ConsoleColor.White, 250);
            Util.PrintLine("던전을 탐험하고 보물을 얻고 경험치를 쌓읍시다!", ConsoleColor.White, 205);
            Util.PrintLine("탑에는 강력한 보스 몬스터들이 살고 있습니다.", ConsoleColor.White, 250);
            Util.PrintLine("각 층을 돌파하면 던전의 몬스터들이 강해지게 됩니다!", ConsoleColor.White, 250);

        }

        public override void Select()
        {
            Util.PrintCharLine("아무키나 눌러 시작...", ConsoleColor.DarkGray, 0);
        }

        public override void Reaction()
        {
        }

        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.ChangeScene("Title");
                    break;
                case ConsoleKey.D2:
                    GameManager.Exit();
                    break;
            }
        }

    }
}
