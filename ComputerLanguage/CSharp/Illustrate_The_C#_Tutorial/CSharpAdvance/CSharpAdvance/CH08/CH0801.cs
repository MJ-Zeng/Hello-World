using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH08
{
    /*约束类型
     new():表示T类型只接收无参数的构造函数
     struct:值类型约束
     class:引用类型约束
     自定义类型约束
        
     */

    //new约束
    class MyClass
    {
        //默认无参数构造函数
    }

    interface It
    {

    }

    //自定义类型约束
    class MyClass2
    {
        
    }

    /// <summary>
    /// 泛型约束
    /// </summary>
    class CH0801
    {
        public static void Show<T>(T t) where T : new()
        {
            Console.WriteLine(t);
        }
        public static void Show2<T>(T t) where T : MyClass2
        {
            Console.WriteLine(t);
        }
        public CH0801()
        {
            MyClass mc = new MyClass();
            Show(mc);

            It it = null;
            //Show(it);  不满足new约束

            MyClass2 mc2 = new MyClass2();
            Show2(mc2); //约束传入的泛型类型只能是 MyClass2
        }
    }
}
