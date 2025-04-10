using ConsoleProject.Item.Weapon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Item;
using ConsoleProject.Item.Armor;

namespace ConsoleProject.Scenes
{
    class ArmorShopScene : Scene, IShop
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
            if (text2 != null)
            {
                Util.PrintLine($"{text2}", ConsoleColor.White);
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
            Util.Print("1. 천 갑옷 구입               방어력 +  3   ");
            Util.PrintLine("1500G", ConsoleColor.DarkYellow);
            Util.Print("2. 가죽 갑옷 구입             방어력 +  8   ");
            Util.PrintLine("4000G", ConsoleColor.DarkYellow);
            Util.Print("3. 판금 갑옷 구입             방어력 + 15   ");
            Util.PrintLine("7500G", ConsoleColor.DarkYellow);
            Util.Print("4. 사슬 갑옷 구입             방어력 + 20  ");
            Util.PrintLine("10000G", ConsoleColor.DarkYellow);
            Util.Print("5. 미스릴 판금 갑옷 구입      방어력 + 35  ");
            Util.PrintLine("20000G", ConsoleColor.DarkYellow);
            Util.Print("6. 아다만티움 판금 갑옷 구입  방어력 + 50  ");
            Util.PrintLine("30000G", ConsoleColor.DarkYellow);
            Util.PrintLine("7. 나가기");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.D2:
                case ConsoleKey.D3:
                case ConsoleKey.D4:
                case ConsoleKey.D5:
                case ConsoleKey.D6:

                    GameManager.armor = GameManager.armorFactory.Create((ArmorList)(key - ConsoleKey.D1));

                    if (GameManager.player.Gold < GameManager.armor.Price)
                    {
                        text1 = "돈이 부족하신데요?";
                        text2 = null;
                        text3 = null;
                        return;
                    }
                    text1 = "구매 감사합니다!";
                    text2 = $"[ {GameManager.armor.Name} 구입 ]";
                    text3 = $"-{GameManager.armor.Price}G";


                    break;

                case ConsoleKey.D7:
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
                case ConsoleKey.D5:
                case ConsoleKey.D6:
                    if (GameManager.player.Gold < GameManager.armor.Price)
                    {
                        return;
                    }
                    GameManager.player.Gold -= GameManager.armor.Price;
                    GameManager.inventory.AddItem(GameManager.armor);
                    break;
                case ConsoleKey.D7:
                    GameManager.ChangeScene("Town");
                    text1 = null;
                    text2 = null;
                    text3 = null;
                    break;
            }
        }
    }
}
