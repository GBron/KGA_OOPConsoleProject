using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class FieldScene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("                                           ＿＿    ");
            Util.PrintLine("                                      ｜＿｜  ｜＿｜  ");
            Util.PrintLine("                                      ｜          ｜");
            Util.PrintLine("                                      ｜  □    □  ｜");
            Util.PrintLine("     ＿＿＿                           ｜  □    □  ｜");
            Util.PrintLine("   ／  ＿  ＼                         ｜   ＿＿   ｜");
            Util.PrintLine("  /   /＿\\   \\                        ｜  ｜  ｜  ｜");
            Util.PrintLine(",...,., ., ., ., ,.,. ,. , ., . , ., .,,.,.,.,.., .,.", ConsoleColor.Green);
            Util.PrintLine(".,.,,., .,.,.,.,. ,.,., .,.,.,.,. .,.,. ,.,.,.,.,.,.,", ConsoleColor.Green);
            Util.PrintLine(".,., .,,.,,. ,. ,., .,.,.,.,.,.,. ,.,.  ,.,., ., .,.,", ConsoleColor.Green);
            Util.PrintLine(".,.,,.,.. ,.,. ,., .,.,.,. ,,.,, . ,., ,.,. , ,.,.,.,", ConsoleColor.Green);
            Util.PrintLine(",.,..,., .,,. ., .,  ,. , .,.,, . , ., ., .,.,.., .,.", ConsoleColor.Green);
            Util.PrintLine("푸른 들판이 너머로 던전과 탑이 보입니다.");
            Util.PrintLine("어디로 가시겠습니까?");
        }

        public override void Select()
        {
            Util.PrintLine("1. 던전으로");
            Util.PrintLine("2. 탑으로");
            Util.PrintLine("3. 마을로");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("던전으로 갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("탑으로 갑니다.", ConsoleColor.White, 1500);
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("마을로 돌아갑니다.", ConsoleColor.White, 1500);
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
                    GameManager.ChangeScene("Battle");
                    Util.RandomMonster();
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("Tower");
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("Town");
                    break;

            }
        }
    }
}
