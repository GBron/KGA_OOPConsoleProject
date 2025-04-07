using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject.status
{
    public abstract class Status
    {
        public virtual void ShowStatus()
        {
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
            Console.WriteLine("체력 : {0} / {1}");
            Console.WriteLine("공격력 : {0}");
            Console.WriteLine("방어력 : {0}");
            Console.WriteLine("힘 : {0}");
            Console.WriteLine("민첩 : {0}");
            Console.WriteLine("□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□");
        }
    }
}
