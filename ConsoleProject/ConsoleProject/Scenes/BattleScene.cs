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
                    GameManager.battle.PlayerAttack();
                    break;
                case ConsoleKey.D2:
                    GameManager.battle.PlayerDefense();
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("당신은 던전 밖으로 도망쳤습니다...", ConsoleColor.White, 1500);
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
                        GameManager.battle.BattleEnd();
                    }
                    else
                    {
                        GameManager.battle.MonsterAttack();
                    }
                    break;
                case ConsoleKey.D2:
                    GameManager.battle.MonsterAttack();
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("Field");
                    break;
            }
        }
    }
}
