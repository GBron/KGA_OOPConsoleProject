using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleProject.Item.Weapon;

namespace ConsoleProject.Scenes
{
    public class WeaponShopScene : Scene, IShop
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
            Util.Print("1. 목검 구입           공격력 + 10   ");
            Util.PrintLine("1500G", ConsoleColor.DarkYellow);
            Util.Print("2. 청동검 구입         공격력 + 15   ");
            Util.PrintLine("3000G", ConsoleColor.DarkYellow);
            Util.Print("3. 철검 구입           공격력 + 20   ");
            Util.PrintLine("5000G", ConsoleColor.DarkYellow);
            Util.Print("4. 강철검 구입         공격력 + 30  ");
            Util.PrintLine("10000G", ConsoleColor.DarkYellow);
            Util.Print("5. 미스릴검 구입       공격력 + 45  ");
            Util.PrintLine("20000G", ConsoleColor.DarkYellow);
            Util.Print("6. 아다만티움검 구입   공격력 + 60  ");
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

                    GameManager.weapon = GameManager.weaponFactory.Create((WeaponList)(key - ConsoleKey.D1));

                    if (GameManager.player.Gold < GameManager.weapon.Price)
                    {
                        text1 = "돈이 부족하신데요?";
                        text2 = null;
                        text3 = null;
                        return;
                    }
                    text1 = "구매 감사합니다!";
                    text2 = $"[ {GameManager.weapon.Name} 구입 ]";
                    text3 = $"-{GameManager.weapon.Price}G";

                    
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
                    if (GameManager.player.Gold < GameManager.weapon.Price)
                    {
                        return;
                    }
                    GameManager.player.Gold -= GameManager.weapon.Price;
                    GameManager.inventory.AddItem(GameManager.weapon);
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
