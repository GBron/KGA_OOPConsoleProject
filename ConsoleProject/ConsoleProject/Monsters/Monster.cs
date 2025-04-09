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

        private int totalDamage;
        public int TotalDamage { get { return totalDamage; } set { totalDamage = value; } }

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

        
    }
}
