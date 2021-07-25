using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH07
{
    /*
     隐式引用转换：
        1.所有引用类型都可以隐式转换为object类型
        2.任何类型都可以隐式转换成它继承的类
        3.类可以隐式转换到：它继承链中的任何类或接口

    显示引用转换：从一个普通类到一个更精确类的转换
        1.object到任何引用类型的转换
        2.从基类到它继承任何类的转换
     */


    class A
    {
        public int Field1;
    }

    class B
    {
        public int Field2;
    }
    /// <summary>
    /// 7.2 引用转换
    /// </summary>
    class CH0702
    {
        public CH0702()
        {
            A GetA = new A();
            //B GetB =(A)GetA; 转换是多余的
            Console.WriteLine(GetA.Field1);
        }

    }
}
