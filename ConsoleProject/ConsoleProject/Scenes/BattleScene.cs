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
            Util.PrintLine("3. 도주");
        }
        public override void Reaction()
        {
            switch (key)
            {
                case ConsoleKey.D1:
                    GameManager.monsterBattle.PlayerAttack();
                    break;
                case ConsoleKey.D2:
                    GameManager.monsterBattle.PlayerDefense();
                    break;
                case ConsoleKey.D3:
                    Util.PrintLine("당신은 던전 밖으로 도망쳤습니다...", ConsoleColor.White, 1500);
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
                    if (GameManager.curMonster.Hp <= 0)
                    {
                        GameManager.monsterBattle.BattleEnd();
                    }
                    else
                    {
                        GameManager.monsterBattle.MonsterAttack();
                        if (GameManager.player.Hp <= 0)
                        {
                            GameManager.monsterBattle.PlayerDead();
                        }
                    }
                    break;
                case ConsoleKey.D2:
                    GameManager.monsterBattle.MonsterAttack();
                    if (GameManager.player.Hp <= 0)
                    {
                        GameManager.monsterBattle.PlayerDead();
                    }
                    
                    break;
                case ConsoleKey.D3:
                    GameManager.ChangeScene("Field");
                    break;

            }
        }
    }
}
