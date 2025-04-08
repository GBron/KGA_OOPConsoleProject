using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.status
{
    public class EnemyStatus : Status
    {
        public override void ShowStatus()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine($"적 이름 : {GameManager.curMonster.Name}");
            Console.WriteLine($"체력    : {GameManager.curMonster.Hp,5} / {GameManager.curMonster.MaxHp,5}");
            Console.WriteLine($"공격력  : {GameManager.curMonster.Damage,5} 방어력 : {GameManager.curMonster.Defense, 5}");
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }
    }
}
