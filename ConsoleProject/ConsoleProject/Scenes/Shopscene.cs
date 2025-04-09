namespace ConsoleProject.Scenes
{
    public class Shopscene : Scene
    {
        private string text1;
        private string text2;
        private string text3;

        public override void MainScene()
        {
            if(text1 == null)
            {
                text1 = "어서 오세요! 좋은 물건 많아요!";
            }

            Util.PrintLine("       ＿＿＿＿      ");
            Util.PrintLine("     ／        ＼    ");
            Util.PrintLine($"    (   ^    ^   )   {text1}");
            Util.PrintLine("     ＼   --   ／    ");
            Util.Print("    ┌            ┐   ");
            if (key == ConsoleKey.D1)
            {
                Util.PrintLine($"{text2}", ConsoleColor.DarkRed);
            }
            else if (key == ConsoleKey.D2)
            {
                Util.PrintLine($"{text2}", ConsoleColor.DarkCyan);
            }
            else if (key == ConsoleKey.D3)
            {
                Util.PrintLine($"{text2}", ConsoleColor.Red);
            }
            else
            {
                Util.PrintLine("");
            }
            Util.Print("    ┃            ┃   ");
            Util.PrintLine($"{text3}", ConsoleColor.DarkGray);
        }

        public override void Select()
        {
            Util.Print("1. 힘의 포션 구입 ");
            Util.Print("[ 힘 + 1 ] ", ConsoleColor.DarkRed);
            Util.PrintLine("2000 G", ConsoleColor.DarkYellow);
            Util.Print("2. 민첩의 포션 구입 ");
            Util.Print("[ 민첩 + 1 ] ", ConsoleColor.DarkCyan);
            Util.PrintLine("2000G", ConsoleColor.DarkYellow);
            Util.Print("4. 활력의 포션 구입 ");
            Util.Print("[ 체력 + 10 ] ", ConsoleColor.Red);
            Util.PrintLine("3000G", ConsoleColor.DarkYellow);
            Util.PrintLine("4. 나가기");
        }
        
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    if(GameManager.player.Gold < 2000)
                    {
                        text1 = "돈이 부족하신데요?";
                        text2 = null;
                        text3 = null;
                        return;
                    }
                    text1 = "구매 감사합니다!";
                    text2 = "[ 힘이 더욱 증가했습니다 ]";
                    text3 = "-2000G";
                    break;
                case ConsoleKey.D2:
                    if (GameManager.player.Gold < 2000)
                    {
                        text1 = "돈이 부족하신데요?";
                        text2 = null;
                        text3 = null;
                        return;
                    }
                    text1 = "구매 감사합니다!";
                    text2 = "[ 몸이 더욱 민첩해졌습니다 ]";
                    text3 = "-2000G";
                    break;
                case ConsoleKey.D3:
                    if (GameManager.player.Gold < 3000)
                    {
                        text1 = "돈이 부족하신데요?";
                        text2 = null;
                        text3 = null;
                        return;
                    }
                    text1 = "구매 감사합니다!";
                    text2 = "[ 활력이 느껴집니다 ]";
                    text3 = "-3000G";
                    break;
                case ConsoleKey.D4:
                    Util.PrintLine("상점을 나갑니다.", ConsoleColor.White, 1500);
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
                    if (GameManager.player.Gold < 3000)
                    {
                        return;
                    }
                    GameManager.player.Gold -= 3000;
                    GameManager.player.MaxHp += 10;
                    GameManager.player.Hp = GameManager.player.MaxHp;
                    break;
                case ConsoleKey.D4:
                    GameManager.ChangeScene("Town");
                    text1 = null;
                    text3 = null;
                    break;
            }
        }
    }
}
