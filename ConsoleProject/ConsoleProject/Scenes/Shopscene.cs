namespace ConsoleProject.Scenes
{
    public class Shopscene : Scene
    {
        private string text;

        public override void MainScene()
        {
            if(text == null)
            {
                text = "어서 오세요! 어떤 물건을 찾으시나요?";
            }

            Util.PrintLine("   ＿＿＿＿      ");
            Util.PrintLine(" ／        ＼    ");
            Util.PrintLine($"(   ^    ^   )   {text}");
            Util.PrintLine(" ＼   --   ／    ");
            Util.PrintLine("┌            ┐   ");
            Util.PrintLine("┃            ┃   ");
            Util.PrintLine("");
        }

        public override void Select()
        {
            Util.Print("1. 힘의 포션 구입 ");
            Util.Print("[ 힘 + 1 ] ", ConsoleColor.DarkRed);
            Util.PrintLine("200 G", ConsoleColor.DarkYellow);
            Util.Print("2. 민첩의 포션 구입");
            Util.Print("[ 민첩 + 1 ] ", ConsoleColor.DarkGreen);
            Util.PrintLine("2000G", ConsoleColor.DarkYellow);
            Util.PrintLine("3. 나가기");
        }
        
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    if(GameManager.player.Gold < 2000)
                    {
                        text = "돈이 부족하신데요?";
                        return;
                    }
                    text = "구매 감사합니다!";
                    break;
                case ConsoleKey.D2:
                    if (GameManager.player.Gold < 2000)
                    {
                        text = "돈이 부족하신데요?";
                        return;
                    }
                    text = "구매 감사합니다!";
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("상점을 나갑니다.");
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
                    if (GameManager.player.Gold < 2000)
                    {
                        return;
                    }
                    GameManager.player.Gold -= 2000;
                    GameManager.player.STR += 1;
                    break;
                case ConsoleKey.D2:
                    if (GameManager.player.Gold < 2000)
                    {
                        return;
                    }
                    GameManager.player.Gold -= 2000;
                    GameManager.player.DEX += 1;
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("Town");
                    text = null;
                    break;
            }
        }
    }
}
