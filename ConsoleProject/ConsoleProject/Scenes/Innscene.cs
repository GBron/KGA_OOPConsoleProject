using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleProject.Scenes
{
    public class InnScene : Scene
    {
        private string text1;
        private string text2;
        private string text3;

        public override void MainScene()
        {
            if (text1 == null)
            {
                text1 = "어서 오세요! 휴식하러 오셨나요?";
            }

            Util.PrintLine("       ＿＿＿＿      ");
            Util.PrintLine("     ／        ＼    ");
            Util.PrintLine($"    (   ^    ^   )   {text1}");
            Util.PrintLine("     ＼   --   ／    ");
            Util.Print("    ┌            ┐   ");
            Util.PrintLine($"{text2}", ConsoleColor.Green);
            Util.Print("    ┃            ┃   ");
            Util.PrintLine($"{text3}", ConsoleColor.DarkGray);
        }
        public override void Select()
        {
            Util.Print("1. 휴식하기 ");
            Util.Print("[ 체력 회복 ] ", ConsoleColor.Red);
            Util.PrintLine("100 G", ConsoleColor.DarkYellow);
            Util.PrintLine("2. 나가기");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    if (GameManager.player.Gold < 100)
                    {
                        text1 = "돈이 부족해요.";
                        text2 = null;
                        text3 = null;
                        return;
                    }
                    text1 = "푹 쉬세요~";
                    text2 = "[ 체력이 전부 회복 되었습니다 ]";
                    text3 = "-100G";
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("여관에서 나갑니다.", ConsoleColor.White, 1500);
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
                    if (GameManager.player.Gold < 100)
                    {
                        return;
                    }
                    GameManager.player.Hp = GameManager.player.MaxExp;
                    GameManager.player.Gold -= 100;
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("Town");
                    text1 = null;
                    text2 = null;
                    text3 = null;
                    break;

            }
        }
    }
}
