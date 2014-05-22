using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonFactory.GenernateClass("wangyexin").PrintName();
            Console.ReadLine();

            OperatePerson1 p = new OperatePerson1();
            p.PrintName2();
            Console.ReadLine();

            Operate pp = new OperatePerson1();
            pp.PrintName2();
            Console.ReadLine();
        }
    }
}
