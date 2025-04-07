using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.status
{
    public class PlayerStatus : Status
    {
        public override void ShowStatus()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine($"체력 : {GameManager.player.MaxExp, 4} / {GameManager.player.Hp, 4}");
            Console.WriteLine($"레벨 : {GameManager.player.Level, 3}       경험치 : {GameManager.player.MaxExp, 5} / {GameManager.player.Exp, 5}");
            Console.WriteLine($"힘 : {GameManager.player.STR,3}         민첩 : {GameManager.player.DEX,3}");
            Console.WriteLine($"공격력 : {GameManager.player.Damage, 5}   방어력 : {GameManager.player.Defense, 5}");
            Console.Write($"골드 : {GameManager.player.Gold}");
            Util.PrintCharLine("G", ConsoleColor.Yellow);
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }
    }
  
}
