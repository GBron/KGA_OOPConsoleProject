namespace ConsoleProject.Scenes
{
    public class TownScene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("마을에 도착했습니다.");
            Util.PrintLine("마을은 평화로워 보입니다.");

        }
        public override void Select()
        {
            Util.PrintLine("1. 잡화점");
            Util.PrintLine("2. 무기 상점");
            Util.PrintLine("3. 방어구 상점");
            Util.PrintLine("4. 여관");
            Util.PrintLine("5. 게시판 확인");
            // Util.PrintLine("4. 검 박힌 바위"); 아이템 구현 시 넣기
            Util.PrintLine("6. 마을 밖으로");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("잡화점에 들어갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("무기 상점에 들어갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("방어구 상점에 들어갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D4:
                    Util.PrintLine("여관에 들어갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D5:
                    Util.PrintLine("게시판을 확인합니다.", ConsoleColor.White, 1500);
                    break;
                // case ConsoleKey.D4:
                //     Util.PrintLine("마을의 명물, 성검이 박힌 바위로 다가갑니다.");
                //     break;
                case ConsoleKey.D6:
                    Util.PrintLine("마을 밖으로 나갑니다.", ConsoleColor.White, 1500);
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
                    GameManager.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("WeaponShop");
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("ArmorShop");
                    break;
                case ConsoleKey.D4:
                    GameManager.ChangeScene("Inn");
                    break;
                case ConsoleKey.D5:
                    GameManager.ChangeScene("BulletinBoard");
                    break;
                // case ConsoleKey.D4:
                // // 성검이 박힌 바위 씬으로 이동
                // break;
                case ConsoleKey.D6:
                    GameManager.ChangeScene("Field");
                    break;
            }
        }
    }
}
