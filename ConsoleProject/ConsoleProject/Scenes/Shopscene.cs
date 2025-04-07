namespace ConsoleProject.Scenes
{
    public class Shopscene : Scene
    {
        private string text;

        public override void MainScene()
        {
            Util.PrintLine("상점에 도착했습니다.");
            Util.PrintLine("상점은 아기자기하게 꾸며져 있습니다.");
        }
        public override void Select()
        {
            Util.PrintLine("1. 물건 사기");
            Util.PrintLine("2. 물건 팔기");
            Util.PrintLine("3. 상점 나가기");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    Util.PrintLine("물건을 사러갑니다.");
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("물건을 팔러갑니다.");
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("상점을 나갑니다.");
                    break;
            }
        }
        public override void Result()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    // 상점 물건 사기 씬으로 이동
                    break;
                case ConsoleKey.D2:
                    // 상점 물건 팔기 씬으로 이동
                    break;
                case ConsoleKey.D3:
                    // 마을 탐험 씬으로 이동
                    break;
            }
        }
    }
}
