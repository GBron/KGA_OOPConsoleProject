namespace ConsoleProject.Scenes
{
    public class BattleScene : Scene
    {
        Monsters.MonsterImg MonsterImg = new Monsters.MonsterImg();

        public override void MainScene()
        {
            MonsterImg.PrintMonsterImg(GameManager.curMonster.Name);

            GameManager.enemyStatus.ShowStatus();
        }
        public override void Select()
        {
            Util.PrintLine("1. 공격");
            Util.PrintLine("2. 방어");
            Util.PrintLine("3. 도망");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.player.PlayerAttack();
                    break;
                case ConsoleKey.D2:
                    Util.PrintLine("방어합니다.");
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("도망갑니다.");
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
                    if (GameManager.curMonster.Hp <= 0)
                    {
                        Util.PrintLine($"{GameManager.curMonster.Name}을/를 처치했습니다.", ConsoleColor.White, 1000);
                        GameManager.player.Exp += GameManager.curMonster.Exp;
                        GameManager.player.Gold += GameManager.curMonster.Gold;
                        Util.PrintLine($"{GameManager.curMonster.Exp}의 경험치와 {GameManager.curMonster.Gold}의 골드를 얻었습니다!", ConsoleColor.White, 1000);
                        GameManager.curMonster = null;
                        GameManager.ChangeScene("Field");
                    }
                    else
                    {
                        GameManager.curMonster.MonsterAttack();
                    }
                    break;
                case ConsoleKey.D2:
                    GameManager.curMonster.MonsterAttack();
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("Field");
                    break;
            }
        }
    }
}
