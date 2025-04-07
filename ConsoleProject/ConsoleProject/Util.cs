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
    }
}
