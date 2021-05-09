using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH06
{
    interface Itfc3
    {
        void PrintOut(string s);
    }
    interface Itfc4
    {
        void PrintOut(string s);
    }

    class MyClass4 : Itfc3, Itfc4
    {
        void Itfc3.PrintOut(string s)
        {
            Console.WriteLine($"Itfc3:{s}");
        }

        void Itfc4.PrintOut(string s)
        {
            Console.WriteLine($"Itfc4:{s}");

        }
    }
    /// <summary>
    /// 显式接口实现:限定接口名称，实现接口分离
    /// </summary>
    class CH0605
    {
        public CH0605()
        {
            MyClass4 mc = new MyClass4();
            Itfc3 itfc3 = (Itfc3)mc;
            itfc3.PrintOut("interface 1");
            Itfc4 itfc4 = (Itfc4)mc;
            itfc4.PrintOut("interface 2");  //报错，溢出检测
        }

    }
}
