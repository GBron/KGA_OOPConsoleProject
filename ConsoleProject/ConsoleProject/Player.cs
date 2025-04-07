using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public class Player
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

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

    }
}
