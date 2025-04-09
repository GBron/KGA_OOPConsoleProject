using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.status
{
    public class BossStatus : Status
    {
        public override void ShowStatus()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine($"적 이름 : {GameManager.curBoss.Name}");
            Console.WriteLine($"체력    : {GameManager.curBoss.Hp,5} / {GameManager.curBoss.MaxHp,5}");
            Console.WriteLine($"공격력  : {GameManager.curBoss.Damage,5} 방어력 : {GameManager.curBoss.Defense,5}");
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }
    }
}
