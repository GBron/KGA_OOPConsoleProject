namespace ConsoleProject.Scenes
{
    public class IntroScene : Scene
    {
        public override void MainScene()
        {
            /* 테스트 끝나고 주석 제거할것
            Util.PrintCharLine("세계에 갑작스레 생겨난 마왕의 탑...", ConsoleColor.White, 50);
            Util.PrintCharLine("탑의 각 층에는 강력한 마물들이 살고있다..!", ConsoleColor.White, 50);
            Util.PrintCharLine("탑을 오르고 최상층에 있는 마왕을 무찔러", ConsoleColor.White, 50);
            Util.PrintCharLine("세계에 평화를 가져오자!", ConsoleColor.White, 50);
            Console.WriteLine();
            */
            Util.PrintLine("기본 설명", ConsoleColor.White, 500);
            Util.PrintLine("선택지가 주어졌을 땐 각 선택지에 해당하는");
            Util.PrintLine("숫자를 입력해 선택할 수 있습니다.");
            Util.PrintLine("맵은 마을과 던전, 탑이 있습니다.");
            Util.PrintLine("던전 입장 시 랜덤한 몬스터와 조우하게 됩니다.");
            Util.PrintLine("적을 무찔러 돈과 경험치를 획득하세요!");
            // Util.PrintLine("던전은 들어갈 때 마다 구조가 바뀝니다!"); 
            // Util.PrintLine("던전을 탐험하고 보물을 얻고 경험치를 쌓읍시다!");  // TODO : 던전 미로 구현 후 주석 해제
            Util.PrintLine("탑에는 강력한 보스 몬스터들이 살고 있습니다.");
            Util.PrintLine("각 층을 돌파하면 던전의 몬스터들이 강해지게 됩니다!");
            Util.PrintLine("던전은 7층으로 구성되어 있으며 최상층 마왕을");
            Util.PrintLine("무찌르면 클리어 됩니다!");
        }

        public override void Select()
        {
            Util.PrintCharLine("아무키나 눌러 시작...", ConsoleColor.DarkGray);
        }


        public override void Reaction()
        {
        }

        public override void Wait()
        {
        }

        public override void Result()
        {
            GameManager.ChangeScene("Town");
        }

    }
}
