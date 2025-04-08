using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Player
    {
        private int level;
        public int Level { get { return level; } set { level = value; } }

        private int exp;
        public int Exp { get { return exp; } set { exp = value; } }

        private int maxExp;
        public int MaxExp { get { return maxExp; } set { maxExp = value; } }

        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        private int maxHp;
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }

        private int hp;
        public int Hp { get { return hp; } set { hp = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }
        
        private int defense;
        public int Defense { get { return defense; } set { defense = value; } }

        private int strength;
        public int STR { get { return strength; } set { strength = value; } }

        private int dexterity;
        public int DEX { get { return dexterity; } set { dexterity = value; } }

        public void PlayerAttack()
        {
            GameManager.curMonster.MonsterTakenDamage();
        }

        public void PlayerTakenDamage()
        {
            if (GameManager.player.Defense < GameManager.curMonster.Damage)
            {
                GameManager.player.Hp -= (GameManager.curMonster.Damage - GameManager.player.Defense);
                Util.PrintLine($"{GameManager.curMonster.Name}의 공격!", ConsoleColor.DarkRed);
                Util.Print($"{GameManager.curMonster.Name}이/가 플레이어에게 ");
                Util.Print($"{(GameManager.curMonster.Damage - GameManager.player.Defense)}", ConsoleColor.Red);
                Util.PrintLine("의 피해를 입었습니다.\n", ConsoleColor.White, 1500);

                return;
            }
            Util.Print("플레이어가 공격을 방어했습니다.\n", ConsoleColor.White, 1500);
        }
    }
}
