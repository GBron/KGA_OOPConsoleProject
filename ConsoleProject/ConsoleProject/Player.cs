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

        private int criticalChance;
        public int CriticalChance { get { return criticalChance; } set { criticalChance = value; } }

        public void LevelUp ()
        {
            if (Exp >= MaxExp)
            {
                Level++;
                Exp -= MaxExp;
                MaxExp = (int)(MaxExp * 1.5);
                MaxHp += 10;
                Hp = MaxHp;
                Defense += 1;
                STR += 1;
                DEX += 1;
                Util.PrintLine("레벨업!", ConsoleColor.Yellow, 1000);
            }
        }
    }
}
