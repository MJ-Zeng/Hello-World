using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH05
{
    delegate void GenericDelegate<T>(T t);  //定义泛型委托
    
    class GenericDelegateClass
    {
        public static void InvokeDelegate()
        {
            GenericDelegate<string> strDelegate = new GenericDelegate<string>(Method1);
            Action<string> action = new Action<string>(Method1);    //官方版本（不带返回值）
            Func<string, string> func = new Func<string, string>(Method3);  //带返回值
            GenericDelegate<int> intDelegate = new GenericDelegate<int>(Method2);
            strDelegate("我是string类型委托1");
            action("我是string类型委托2");
            var str = func("我是带返回值的func的委托");
            intDelegate(2);
            Console.WriteLine(str);
        }

        public static void Method1(string str)
        {
            Console.WriteLine(str);
        }
        public static void Method2(int x)
        {
            Console.WriteLine($"我是int{x}委托");
        }
        public static string Method3(string str)
        {
            return str;
        }
    }
    /// <summary>
    /// 泛型委托+Action+Func
    /// </summary>
    class CH0504
    {
        public CH0504()
        {
            GenericDelegateClass.InvokeDelegate();
        }
    }
}
