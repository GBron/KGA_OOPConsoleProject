using ConsoleProject.Item.UsableItem;
using ConsoleProject.Item.Weapon;
namespace ConsoleProject.Scenes
{
    public class Shopscene : Scene, IShop
    {
        private string text1;
        private string text2;
        private string text3;

        public override void MainScene()
        {
            if (text1 == null)
            {
                text1 = "어서 오세요! 좋은 물건 많아요!";
            }

            Util.PrintLine("       ＿＿＿＿      ");
            Util.PrintLine("     ／        ＼    ");
            Util.PrintLine($"    (   ^    ^   )   {text1}");
            Util.PrintLine("     ＼   --   ／    ");
            Util.Print("    ┌            ┐   ");
            
            if (key == ConsoleKey.D5)
            {
                Util.PrintLine($"{text2}", ConsoleColor.DarkRed);
            }
            else if (key == ConsoleKey.D6)
            {
                Util.PrintLine($"{text2}", ConsoleColor.DarkCyan);
            }
            else if (text2 != null)
            {
                Util.PrintLine($"{text2}", ConsoleColor.Yellow);
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
            Util.Print("1. 소형 회복 포션 구입               ");
            Util.PrintLine("100G", ConsoleColor.DarkYellow);
            Util.Print("2. 회복 포션 구입                    ");
            Util.PrintLine("200G", ConsoleColor.DarkYellow);
            Util.Print("3. 대형 회복 포션 구입               ");
            Util.PrintLine("500G", ConsoleColor.DarkYellow);
            Util.Print("4. 특대형 포션 구입                 ");
            Util.PrintLine("1500G", ConsoleColor.DarkYellow);
            Util.Print("5. 힘의 포션 구입       ");
            Util.Print("[ 힘 + 1 ]  ", ConsoleColor.DarkRed);
            Util.PrintLine("2000G", ConsoleColor.DarkYellow);
            Util.Print("6. 민첩의 포션 구입    ");
            Util.Print("[ 민첩 + 1 ] ", ConsoleColor.DarkCyan);
            Util.PrintLine("2000G", ConsoleColor.DarkYellow);
            Util.PrintLine("0. 나가기");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                    if (GameManager.inventory.inventory.Count < 9)
                    {
                        GameManager.potion = GameManager.potionFactory.Create((PotionList)(key - ConsoleKey.D1));

                        if (GameManager.player.Gold < GameManager.potion.Price)
                        {
                            text1 = "돈이 부족하신데요?";
                            text2 = null;
                            text3 = null;
                            return;
                        }
                        text1 = "구매 감사합니다!";
                        text2 = $"[ {GameManager.potion.Name} 구입 ]";
                        text3 = $"-{GameManager.potion.Price}G";
                    }
                    break;
                case ConsoleKey.D5:
                    if (GameManager.player.Gold < 2000)
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
                case ConsoleKey.D6:
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
                case ConsoleKey.D0:
                    Util.PrintLine("상점을 나갑니다.", ConsoleColor.White, 1500);
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
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                    if (GameManager.inventory.inventory.Count < 9)
                    {
                        if (GameManager.player.Gold < GameManager.potion.Price)
                        {
                            return;
                        }
                        GameManager.player.Gold -= GameManager.potion.Price;
                        GameManager.inventory.AddItem(GameManager.potion);
                    }
                    else
                        Util.PrintLine("인벤토리가 가득 찼습니다.", ConsoleColor.Yellow, 1500);
                    break;
                case ConsoleKey.D5:
                    if (GameManager.player.Gold < 2000)
                    {
                        return;
                    }
                    GameManager.player.Gold -= 2000;
                    GameManager.player.STR += 1;
                    break;
                case ConsoleKey.D6:
                    if (GameManager.player.Gold < 2000)
                    {
                        return;
                    }
                    GameManager.player.Gold -= 2000;
                    GameManager.player.DEX += 1;
                    break;
                
                case ConsoleKey.D0:
                    GameManager.ChangeScene("Town");
                    text1 = null;
                    text3 = null;
                    break;

            }
        }
    }
}
