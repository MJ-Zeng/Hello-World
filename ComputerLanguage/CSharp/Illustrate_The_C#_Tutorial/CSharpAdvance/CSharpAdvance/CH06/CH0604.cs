using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH06
{
    interface Itfc1
    {
        void PrintOut(string s);
    }
    interface Itfc2
    {
        void PrintOut(string s);
    }

    class MyClass3 : Itfc1, Itfc2
    {
        public void PrintOut(string s)
        {
            Console.WriteLine($"Call Through:{s}");
        }
    }
    /// <summary>
    /// 实现具有重复成员的接口:实现单个成员满足所有接口
    /// </summary>
    class CH0604 
    {
        
        public CH0604()
        {
            MyClass3 mc = new MyClass3();
            mc.PrintOut("Object");
        }
    }
}
