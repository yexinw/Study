using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式
{
    public class Operate
    {
        public string Name { get; set; }
        public virtual void PrintName()
        {
            Console.WriteLine(Name);
        }

        public void PrintName2()
        {
            Console.WriteLine(Name + "2基类");
        }
    }
}
