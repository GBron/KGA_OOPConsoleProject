using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    public static class Util
    {

        public static void PrintLine(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Console.WriteLine(text);
            Thread.Sleep(delay);
            Console.ResetColor();
        }

        public static void PrintCharLine(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        public static void Print(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            Console.Write(text);
            Thread.Sleep(delay);
            Console.ResetColor();
        }

        public static void PrintChar(string text, ConsoleColor textColor = ConsoleColor.White, int delay = 0)
        {
            Console.ForegroundColor = textColor;
            for (int i = 0; i < text.Length; i++)
            {
                Console.Write(text[i]);
                Thread.Sleep(delay);
            }
            Console.ResetColor();
        }

        public static void RandomMonster()
        {
            int rand = GameManager.rand.Next(1, 101);

            if (rand <= 10)
                GameManager.ChangeMonster(Monsters.MonsterList.오크);
            else if (rand > 10 && rand <= 25)
                GameManager.ChangeMonster(Monsters.MonsterList.코볼트);
            else if (rand > 25 && rand <= 50)
                GameManager.ChangeMonster(Monsters.MonsterList.고블린);
            else if (rand > 50 && rand <= 100)
                GameManager.ChangeMonster(Monsters.MonsterList.슬라임);
        }
    }
}
