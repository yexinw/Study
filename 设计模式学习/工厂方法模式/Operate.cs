using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    public class Operate
    {
        public string Name { get; set; }
        public virtual void PrintName()
        {
            Console.WriteLine(Name);
        }
    }
}
