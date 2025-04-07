﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class Townscene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("마을에 도착했습니다.");
            Util.PrintLine("마을은 평화로워 보입니다.");

        }
        public override void Select()
        {
            Util.PrintLine("1. 상점");
            Util.PrintLine("2. 여관");
            Util.PrintLine("3. 게시판 확인");
            Util.PrintLine("4. 검 박힌 바위");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("상점에 들어갑니다.");
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("여관에 들어갑니다.");
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("게시판을 확인합니다.");
                    break;
                case ConsoleKey.D4:
                    Util.PrintLine("마을의 명물, 성검이 박힌 바위로 다가갑니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Util.PrintLine("아무키나 눌러주세요.", ConsoleColor.DarkGray);
            Console.ReadKey(true);
        }

        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.ChangeScene("Shop");
                    break;
                case ConsoleKey.D2:
                    GameManager.ChangeScene("Inn");
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("BulletinBoard");
                    break;
                case ConsoleKey.D4:
                    // 성검이 박힌 바위 씬으로 이동
                    break;
            }
        }
    }
}
