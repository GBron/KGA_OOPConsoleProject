namespace ConsoleProject.Item.Weapon
{
    public class Weapon : IItem, IEquipable
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }

        private int damage;
        public int Damage { get { return damage; } set { damage = value; } }

        private int price;
        public int Price { get { return price; } set { price = value; } }

        public Weapon(string name, int damage, int price)
        {
            Name = name;
            Damage = damage;
            Price = price;
        }

    }
}
