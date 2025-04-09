namespace ConsoleProject
{
    public class Battle
    {
        int playerTempDefense = 0;
        bool isCritical = false;

        public void PlayerAttack()
        {
            PlayerTotalDamage();

            if (GameManager.player.TotalDamage > 0)
            {
                GameManager.curMonster.Hp -= GameManager.player.TotalDamage;
                Util.PrintLine($"플레이어의 공격!", ConsoleColor.DarkGreen, 500);
                if(isCritical)
                    Util.Print("[ 크리티컬! ] ", ConsoleColor.Yellow);
                Util.Print($"플레이어가 {GameManager.curMonster.Name}에게 ");
                Util.Print($"{GameManager.player.TotalDamage}", ConsoleColor.Red);
                Util.PrintLine("의 피해를 입혔습니다.\n", ConsoleColor.White, 1000);
                return;
            }
            Util.PrintLine($"플레이어의 공격!", ConsoleColor.DarkGreen, 500);
            Util.Print($"{GameManager.curMonster.Name}이/가 공격을 방어했습니다.\n", ConsoleColor.White, 1500);
        }

        public void PlayerDefense()
        {
            Util.PrintLine($"플레이어의 방어!", ConsoleColor.DarkGreen);
            Util.Print("플레이어가 방어를 준비합니다.", ConsoleColor.White, 200);
            playerTempDefense = GameManager.player.Defense;
            Util.PrintLine("[ 일시적 방어력 상승 ]\n", ConsoleColor.DarkBlue, 1000);
        }
        
        private void PlayerTotalDamage()
        {
            isCritical = false;

            if (GameManager.rand.Next(1, 101) < GameManager.player.criticalChance)
            {
                isCritical = true;
                GameManager.player.TotalDamage =
                    ((int)(GameManager.player.Damage * (1f + ((float)GameManager.player.STR / 100)))) * 2 - GameManager.curMonster.Defense;
                return;
            }

            GameManager.player.TotalDamage = 
                (int)(GameManager.player.Damage * (1f + ((float)GameManager.player.STR / 100))) - GameManager.curMonster.Defense;
        }

        public void MonsterAttack()
        {
            MonsterTotalDamage();

            if (GameManager.curMonster.TotalDamage > 0)
            {
                GameManager.player.Hp -= GameManager.curMonster.TotalDamage;
                Util.PrintLine($"{GameManager.curMonster.Name}의 공격!", ConsoleColor.DarkRed, 500);
                Util.Print($"{GameManager.curMonster.Name}이/가 플레이어에게 ");
                Util.Print($"{GameManager.curMonster.TotalDamage}", ConsoleColor.Red);
                Util.PrintLine("의 피해를 입혔습니다.\n", ConsoleColor.White, 1500);

                return;
            }
            Util.PrintLine($"{GameManager.curMonster.Name}의 공격!", ConsoleColor.DarkRed, 500);
            Util.Print("플레이어가 공격을 방어했습니다.\n", ConsoleColor.White, 1500);
        }

        public void MonsterSkill()
        {

        }

        private void MonsterTotalDamage()
        {
            GameManager.curMonster.TotalDamage = 
                GameManager.curMonster.Damage - (GameManager.player.Defense + playerTempDefense);
        }

        public void BattleEnd()
        {
            Util.PrintLine($"{GameManager.curMonster.Name}을/를 처치했습니다.", ConsoleColor.White, 1000);
            GameManager.player.Exp += GameManager.curMonster.Exp;
            GameManager.player.Gold += GameManager.curMonster.Gold;
            Util.PrintLine($"{GameManager.curMonster.Exp}의 경험치와 {GameManager.curMonster.Gold}의 골드를 얻었습니다!", ConsoleColor.White, 1000);
            GameManager.player.LevelUp();
            GameManager.curMonster = null;
            GameManager.ChangeScene("Field");
        }
    }
}
