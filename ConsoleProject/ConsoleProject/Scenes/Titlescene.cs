namespace ConsoleProject.Scenes
{
    public class Titlescene : Scene
    {
        public override void MainScene()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine();
            Console.WriteLine("                  TEXT RPG                   ");
            Console.WriteLine();
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }
        public override void Select()
        {
            Console.WriteLine("1. 시작");
            Console.WriteLine("2. 종료");
        }

        public override void Reaction()
        {
            Console.WriteLine("반응");
        }
        public override void Result()
        {
            Console.WriteLine("결과");
        }
    }

}

