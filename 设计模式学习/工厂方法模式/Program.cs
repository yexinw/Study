using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    class Program
    {
        static void Main(string[] args)
        {
            IFactory factory = new Person1Factory();
            Operate operate = factory.Create();
            operate.Name = "wangyexintest";
            operate.PrintName();
            Console.ReadLine();
        }
    }
}
