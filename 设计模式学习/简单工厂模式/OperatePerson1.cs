using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式
{
    public class OperatePerson1 : Operate
    {
        public override void PrintName()
        {
            Console.WriteLine("基类" + Name);
        }

        public void PrintName2()
        {
            Console.WriteLine(Name + "2派生类");
        }
    }
}
