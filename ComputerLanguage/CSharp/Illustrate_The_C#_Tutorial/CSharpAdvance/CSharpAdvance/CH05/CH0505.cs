using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH05
{
    /// <summary>
    /// 多播委托
    /// </summary>
    class CH0505
    {
        public CH0505()
        {
            Action actiond = Method1;    //语法糖==new action(Method1)
            actiond += Method2;     //
            actiond = (Action)MulticastDelegate.Combine(actiond,new Action(Method3));
            actiond -= Method3;
            actiond();
        }

        public static void Method1()
        {

            Console.WriteLine("我是method1");
        }
        public static void Method2()
        {

            Console.WriteLine("我是method2");
        }
        public static void Method3()
        {

            Console.WriteLine("我是method3");
        }
    }


}
