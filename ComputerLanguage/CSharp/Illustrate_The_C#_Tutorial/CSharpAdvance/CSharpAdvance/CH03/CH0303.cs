using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH03
{
    class MyBaseClass
    {
        public void Print()
        {
            Console.WriteLine("this is base class");
        }
    }
    class MyDerivedClass : MyBaseClass
    {
        new public void Print()
        {
            Console.WriteLine("this is drived class");
        }
    }
    /// <summary>
    /// 派生类转换基类引用
    /// </summary>
    class CH0303
    {
        public CH0303()
        {
            MyDerivedClass derived = new MyDerivedClass();
            MyBaseClass baseclass = (MyBaseClass)derived;//派生类转基类
            derived.Print();
            baseclass.Print();
        }
    }
}
