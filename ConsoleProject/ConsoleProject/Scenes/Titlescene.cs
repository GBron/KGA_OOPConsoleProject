namespace ConsoleProject.Scenes
{
    public class Titlescene : Scene
    {
        public override void MainScene()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine();
            Console.WriteLine("                      TEXT RPG                       ");
            Console.WriteLine();
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine();
        }

        public override void Select()
        {
            Console.WriteLine("                      1. 시작");
            Console.WriteLine("                      2. 종료");
        }

        public override void Reaction() 
        {
        }

        public override void Wait()
        {
        }

        public override void Result()
        {
            switch(key)
            {
                case ConsoleKey.D1:
                    GameManager.ChangeScene("Explan");
                    break;
                case ConsoleKey.D2:
                    GameManager.Exit();
                    break;
            }
        }
    }
}

