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
            Console.WriteLine($"레벨   : {GameManager.player.Level,5}");
            Util.Print($"경험치 : ");
            Util.Print($"{GameManager.player.Exp,5} / {GameManager.player.MaxExp,5}", ConsoleColor.Yellow);
            Util.Print($" 공격력 : ");
            Util.Print($"{GameManager.player.Damage,5}", ConsoleColor.Magenta);
            Util.Print($" 힘     : ");
            Util.PrintLine($"{GameManager.player.STR,5}", ConsoleColor.DarkRed);
            Util.Print($"체력   : ");
            Util.Print($"{GameManager.player.Hp,5} / {GameManager.player.MaxHp,5}", ConsoleColor.Red);
            Util.Print($" 방어력 : ");
            Util.Print($"{GameManager.player.Defense,5}", ConsoleColor.DarkBlue);
            Util.Print($" 민첩   : ");
            Util.PrintLine($"{GameManager.player.DEX,5}", ConsoleColor.DarkCyan);
            Util.Print($"골드   : ");
            Util.PrintLine($"{GameManager.player.Gold}G", ConsoleColor.DarkYellow);
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }
    }
}
