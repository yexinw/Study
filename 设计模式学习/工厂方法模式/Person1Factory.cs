using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 工厂方法模式
{
    public class Person1Factory : IFactory
    {
        public Operate Create()
        {
            return new PersonOperate1();
        }
    }
}
