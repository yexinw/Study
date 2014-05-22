using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    public class PersonOperate1 : Operate
    {
        public override void PrintName()
        {
            Console.WriteLine("派生类" + Name);
        }
    }
}
