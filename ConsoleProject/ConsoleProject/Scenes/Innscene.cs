using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleProject.Scenes
{
    public class Innscene : Scene
    {
        private string text;
        public override void MainScene()
        {
            if (text == null)
            {
                text = "어서 오세요! 휴식하러 오셨나요?";
            }

            Util.PrintLine("   ＿＿＿＿      ");
            Util.PrintLine(" ／        ＼    ");
            Console.WriteLine("(   ^    ^   )   {0}", text);
            Util.PrintLine(" ＼   --   ／    ");
            Util.PrintLine("┌            ┐   ");
            Util.PrintLine("┃            ┃   ");
            Util.PrintLine("");
        }
        public override void Select()
        {
            Util.Print("1. 휴식하기 ");
            Util.Print("[ 체력 회복 ]", ConsoleColor.Red);
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
                        text = "돈이 부족해요.";
                        return;
                    }
                    text = "푹 쉬세요~";
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("여관에서 나갑니다.");
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
                    text = null;
                    break;
            }
        }
    }
}
