using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.Monsters
{
    public class Monster
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int maxHp;
        public int MaxHp { get { return maxHp; } set { maxHp = value; } }

        private int hp;
        public int Hp { get { return hp; } set { hp = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

        private int defense;
        public int Defense { get { return defense; } set { defense = value; } }

        private int exp;
        public int Exp { get { return exp; } set { exp = value; } }

        private int gold;
        public int Gold { get { return gold; } set { gold = value; } }

        public Monster(string name, int maxHp, int damage, int defense, int exp, int gold)
        {
            this.Name = name;
            this.MaxHp = maxHp;
            this.Hp = maxHp;
            this.Damage = damage;
            this.Defense = defense;
            this.Exp = exp;
            this.Gold = gold;
        }

        public void MonsterAttack()
        {
            GameManager.player.PlayerTakenDamage();
        }

        public void MonsterTakenDamage()
        {
            if(GameManager.curMonster.Defense < GameManager.player.Damage)
            {
                GameManager.curMonster.Hp -= (GameManager.player.Damage - GameManager.curMonster.Defense);
                Util.PrintLine($"플레이어의 공격!", ConsoleColor.DarkGreen);
                Util.Print($"플레이어가 {GameManager.curMonster.Name}에게 ");
                Util.Print($"{(GameManager.player.Damage - GameManager.curMonster.Defense)}", ConsoleColor.Red);
                Util.PrintLine("의 피해를 입었습니다.\n", ConsoleColor.White, 1000);
                return;
            }
            Util.Print($"{GameManager.curMonster.Name}이/가 공격을 방어했습니다.\n", ConsoleColor.White, 1500);
        }
    }
}
