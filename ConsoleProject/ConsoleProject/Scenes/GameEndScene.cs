using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class GameEndScene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Util.PrintLine("");
            Util.PrintLine("");
            Util.PrintLine("");
            Util.PrintLine("                     축하합니다!                     ", ConsoleColor.Green);
            Util.PrintLine("");
            Util.PrintLine("               당신은 마왕을 물리치고                ", ConsoleColor.DarkGreen);
            Util.PrintLine("             세계의 평화를 가져왔습니다!             ", ConsoleColor.DarkGreen);
            Util.PrintLine("");
            Util.PrintLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }

        public override void Select()
        {
            Util.PrintLine("                아무키나 눌러서 종료", ConsoleColor.DarkGray);
        }

        public override void Reaction()
        {
        }

        public override void Wait()
        {
        }

        public override void Result()
        {
        }
    }
}
