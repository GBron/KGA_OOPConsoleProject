using ConsoleProject.Item;
using ConsoleProject.Item.Armor;
using ConsoleProject.Item.Weapon;

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

        public int criticalChance { get { return 1 + DEX / 4; } }

        private int totalDamage;
        public int TotalDamage { get { return totalDamage; } set { totalDamage = value; } }

        public Weapon equipWeapon { get; private set; }

        public Armor equipArmor { get; private set; }


        public void LevelUp()
        {
            while (Exp >= MaxExp)
            {
                Level++;
                Exp -= MaxExp;
                MaxExp = 100 + (Level / 5) * 100;
                MaxHp += 10;
                Hp = MaxHp;
                Defense += 1;
                STR += 1;
                DEX += 1;
                Util.PrintLine("레벨업!", ConsoleColor.Yellow, 1000);
            }
        }

        public void Heal(int healPoint)
        {
            Hp += healPoint;
            if (Hp > MaxHp)
                Hp = MaxHp;
        }

        public void EquipItem(IItem item)
        {
            IItem tempItem = null;
            if (item is Weapon)
                if (equipWeapon != null)
                    tempItem = GameManager.player.equipWeapon;
                else
                    tempItem = GameManager.weaponFactory.Create(WeaponList.없음);
            else if (item is Armor)
                if (equipArmor != null)
                    tempItem = GameManager.player.equipArmor;
                else
                    tempItem = GameManager.armorFactory.Create(ArmorList.없음);

            if (item is Weapon)
            {
                equipWeapon = (Weapon)item;

            }
            else if (item is Armor)
            {
                equipArmor = (Armor)item;
            }

            GameManager.inventory.RemoveItem(item);
            if (tempItem?.Name != "없음")
                GameManager.inventory.AddItem(tempItem);
        }
    }
}
