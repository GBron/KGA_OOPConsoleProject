using ConsoleProject.Item;

namespace ConsoleProject
{
    public class Inventory
    {
        private List<IItem> inventory;
        private Stack<string> stack = new Stack<string>();
        ConsoleKey input;
        int index;

        public Inventory()
        {
            inventory = new List<IItem>(9);
        }

        public void AddItem(IItem item)
        {
            inventory.Add(item);
        }

        public void RemoveItem(IItem item)
        {
            inventory.Remove(item);
        }

        public void RemoveItem(int index)
        {
            inventory.RemoveAt(index);
        }

        public void UseItem(int index)
        {
            if (inventory[index] is IUsable)
            {
                IUsable usableItem = (IUsable)inventory[index];
                usableItem.Use();
                inventory.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("사용할 수 없는 아이템입니다.");
            }
        }


        public void Open()
        {
            stack.Push("Menu");

            while (stack.Count > 0)
            {
                Console.Clear();
                switch (stack.Peek())
                {
                    case "Menu":
                        Menu();
                        break;
                    case "UseMenu":
                        UseMenu();
                        break;
                    case "UseConfirm":
                        UseConfirm();
                        break;
                    case "EquipMenu":
                        EquipMenu();
                        break;
                    case "EquipConfirm":
                        EquipConfirm();
                        break;
                }
            }
        }

        public void Menu()
        {
            ShowInventory();
            Util.PrintLine("1. 아이템 사용");
            Util.PrintLine("2. 아이템 장착");
            Util.PrintLine("0. 나가기");

            input = Console.ReadKey(true).Key;
            switch (input)
            {
                case ConsoleKey.D1:
                    if (inventory.Count > 0)
                    {
                        stack.Push("UseMenu");
                    }
                    else
                        Util.PrintLine("사용할 수 있는 아이템이 없습니다.", ConsoleColor.Yellow, 1000);
                    break;
                case ConsoleKey.D2:
                    if (inventory.Count > 0)
                    {
                        stack.Push("EquipMenu");
                    }
                    else
                        Util.PrintLine("장착할 수 있는 아이템이 없습니다.", ConsoleColor.Yellow, 1000);
                    break;
                case ConsoleKey.D0:
                    stack.Pop();
                    break;
            }
        }

        public void UseMenu()
        {
            ShowInventory();
            Util.PrintLine("사용할 아이템을 선택하세요.");
            Util.PrintLine("0. 뒤로가기");

            input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
                return;
            }

            index = (int)input - (int)ConsoleKey.D1;

            if (index >= 0 && index < 10)
                stack.Push("UseConfirm");
        }

        public void EquipMenu()
        {
            ShowInventory();
            Util.PrintLine("장착할 아이템을 선택하세요.");
            Util.PrintLine("0. 뒤로가기");
            input = Console.ReadKey(true).Key;
            if (input == ConsoleKey.D0)
            {
                stack.Pop();
                return;
            }
            index = (int)input - (int)ConsoleKey.D1;

            if (index >= 0 && index < 10)
                stack.Push("EquipConfirm");
        }

        public void UseConfirm()
        {
            if (index < inventory.Count && inventory[index] is IUsable)
            {
                ShowInventory();
                Util.PrintLine($"{inventory[index].Name}을 사용하시겠습니까?");
                Util.PrintLine("1. 예");
                Util.PrintLine("2. 아니요");

                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        UseItem(index);
                        stack.Pop();
                        break;
                    case ConsoleKey.D2:
                        stack.Pop();
                        break;
                }
            }
            else if (index >= inventory.Count)
            {
                ShowInventory();
                Util.PrintLine("그 슬롯엔 아이템이 없습니다.", ConsoleColor.Yellow, 1000);
                stack.Pop();
            }
            else
            {
                ShowInventory();
                Util.PrintLine("사용할 수 없는 아이템입니다.", ConsoleColor.Yellow, 1000);
                stack.Pop();
            }
        }

        public void EquipConfirm()
        {
            if (index < inventory.Count && inventory[index] is IEquipable)
            {
                ShowInventory();
                Util.PrintLine($"{inventory[index].Name}을 장착하시겠습니까?");
                Util.PrintLine("1. 예");
                Util.PrintLine("2. 아니요");
                input = Console.ReadKey(true).Key;
                switch (input)
                {
                    case ConsoleKey.D1:
                        GameManager.player.EquipItem(inventory[index]);
                        stack.Pop();
                        break;
                    case ConsoleKey.D2:
                        stack.Pop();
                        break;
                }
            }
            else if (index >= inventory.Count)
            {
                ShowInventory();
                Util.PrintLine("그 슬롯엔 아이템이 없습니다.", ConsoleColor.Yellow, 1000);
                stack.Pop();
            }
            else
            {
                ShowInventory();
                Util.PrintLine("장착할 수 없는 아이템입니다.", ConsoleColor.Yellow, 1000);
                stack.Pop();
            }
        }

        public void ShowInventory()
        {
            Util.PrintLine("□□□□□□□□□□ 인벤토리 □□□□□□□□□□");
            if (inventory.Count == 0)
            {
                Util.PrintLine("   인벤토리가 비어있습니다", ConsoleColor.DarkGray);
            }
            for (int i = 0; i < inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {inventory[i].Name}");
            }
            Util.PrintLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");

            Console.SetCursorPosition(32, 0);
            Util.PrintLine("□□□□□□ 장비 □□□□□□");
            Console.SetCursorPosition(32, 1);
            Util.PrintLine($"무기   : {GameManager.player.equipWeapon.Name}");
            Console.SetCursorPosition(32, 2);
            Util.PrintLine($"방어구 : {GameManager.player.equipArmor.Name}");
            Console.SetCursorPosition(32, 3);
            Util.PrintLine("□□□□□□□□□□□□□□□□□□");
            Console.SetCursorPosition(0, 13);

        }


    }
}
