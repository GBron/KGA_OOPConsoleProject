using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Scenes
{
    public class Bulletinboardscene : Scene
    {
        public override void MainScene()
        {
            Util.PrintLine("마을 게시판을 확인합니다.");
            Util.PrintLine("여러가지가 적혀있군요...");
        }

        public override void Select()
        {
            Util.PrintLine("1. 마을 소식 확인");
            Util.PrintLine("2. 퀘스트 확인");
            Util.PrintLine("3. 마왕의 탑 소식 확인");
            Util.PrintLine("4. 나가기");
        }

        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("마을은 별 소식없이 평화롭습니다.");
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("퀘스트가 없습니다...");
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("아직 마왕의 탑은 건재합니다.");
                    break;
                case ConsoleKey.D4:
                    Util.PrintLine("게시판을 떠납니다.");
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
                    // TODO: 게시판-마을 소식 추후 구현
                    break;
                case ConsoleKey.D2:
                    // TODO: 게시판-퀘스트 퀘스트 구현 시 퀘스트 씬으로 이동, 또는 퀘스트 수락
                    break;
                case ConsoleKey.D3:
                    // TODO: 게시판-마왕의 탑 소식 마왕의 탑 씬 구현시 돌파된 층 정보 출력
                    break;
                case ConsoleKey.D4:
                    GameManager.ChangeScene("Town");
                    break;
            }
        }
    }
}
