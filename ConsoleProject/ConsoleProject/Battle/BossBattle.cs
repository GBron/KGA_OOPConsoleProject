using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Battle
{
    public class BossBattle : Battle
    {
        public override void PlayerAttack()
        {
            PlayerTotalDamage();

            if (GameManager.player.TotalDamage > 0)
            {
                GameManager.curBoss.Hp -= GameManager.player.TotalDamage;
                Util.PrintLine($"플레이어의 공격!", ConsoleColor.DarkGreen, 500);
                if (isCritical)
                    Util.PrintLine("[ 크리티컬! ] ", ConsoleColor.Yellow, 500);
                Util.Print($"플레이어가 {GameManager.curBoss.Name}에게 ");
                Util.Print($"{GameManager.player.TotalDamage}", ConsoleColor.Red);
                Util.PrintLine("의 피해를 입혔습니다.\n", ConsoleColor.White, 1000);
                playerTempDefense = 0;
                return;
            }
            Util.PrintLine($"플레이어의 공격!", ConsoleColor.DarkGreen, 500);
            Util.Print($"{GameManager.curBoss.Name}이/가 공격을 방어했습니다.\n", ConsoleColor.White, 1500);
            playerTempDefense = 0;
        }

        public override void PlayerDefense()
        {
            Util.PrintLine($"플레이어의 방어!", ConsoleColor.DarkGreen, 500);
            Util.Print("플레이어가 방어를 준비합니다.", ConsoleColor.White);
            playerTempDefense = (int)GameManager.player.Defense + GameManager.player.equipArmor.Defense;
            Util.PrintLine("[ 일시적 방어력 상승 ]\n", ConsoleColor.DarkBlue, 1000);
        }

        protected override void PlayerTotalDamage()
        {
            isCritical = false;

            if (GameManager.rand.Next(1, 101) < GameManager.player.criticalChance)
            {
                isCritical = true;
                GameManager.player.TotalDamage =
                    (int)((GameManager.player.Damage + GameManager.player.equipWeapon.Damage) * (1f + (float)GameManager.player.STR / 100)) * 2 - GameManager.curBoss.Defense;
                return;
            }

            GameManager.player.TotalDamage =
                (int)((GameManager.player.Damage + GameManager.player.equipWeapon.Damage) * (1f + (float)GameManager.player.STR / 100)) - GameManager.curBoss.Defense;
        }

        public override void MonsterAttack()
        {
            MonsterTotalDamage();

            if (GameManager.curBoss.TotalDamage > 0)
            {
                GameManager.player.Hp -= GameManager.curBoss.TotalDamage;
                Util.PrintLine($"{GameManager.curBoss.Name}의 공격!", ConsoleColor.DarkRed, 500);
                Util.Print("플레이어가 ");
                Util.Print($"{GameManager.curBoss.TotalDamage}", ConsoleColor.Red);
                Util.PrintLine("의 피해를 받았습니다.\n", ConsoleColor.White, 1500);

                return;
            }
            Util.PrintLine($"{GameManager.curBoss.Name}의 공격!", ConsoleColor.DarkRed, 500);
            Util.Print("플레이어가 공격을 방어했습니다.\n", ConsoleColor.White, 1500);
        }

        public override void MonsterSkill()
        {

        }

        protected override void MonsterTotalDamage()
        {
            GameManager.curBoss.TotalDamage =
                GameManager.curBoss.Damage - ((int)(GameManager.player.Defense + GameManager.player.equipArmor.Defense) + playerTempDefense);
        }

        public override void BattleEnd()
        {
            Util.PrintLine($"{GameManager.curBoss.Name}을/를 처치했습니다.", ConsoleColor.White, 1000);
            GameManager.player.Exp += GameManager.curBoss.Exp;
            GameManager.player.Gold += GameManager.curBoss.Gold;
            Util.PrintLine($"{GameManager.curBoss.Exp}의 경험치와 {GameManager.curBoss.Gold}의 골드를 얻었습니다!", ConsoleColor.White, 1000);
            GameManager.player.LevelUp();
            GameManager.curBoss = null;
            GameManager.ChangeScene("Tower2");
        }

        
    }
}
