using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单工厂模式
{
    public class PersonFactory
    {
        public static Operate GenernateClass(string Name)
        {
            Operate operate = new OperatePerson1();
            operate.Name = Name;
            return operate;
        }
    }
}
