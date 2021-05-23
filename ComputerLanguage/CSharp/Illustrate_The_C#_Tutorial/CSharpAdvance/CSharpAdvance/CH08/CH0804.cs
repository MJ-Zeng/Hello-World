using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH08
{
    delegate void MyDel<T>(T t);    //定义泛型委托

    class DelClass
    {
        public static void PrintStr(string s)
        {
            Console.WriteLine(s);
        }
        public static void PrintUpperStr(string s)
        {
            Console.WriteLine(s.ToUpper());
        }
    }

    /// <summary>
    /// 泛型委托
    /// </summary>
    class CH0804
    {
        public CH0804()
        {
            var mydel = new MyDel<string>(DelClass.PrintStr);
            mydel += DelClass.PrintUpperStr;

            mydel("Hello There");
        }
    }
}
