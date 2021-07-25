using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH06
{
    interface IIfc1
    {
        void PrintOut(string s);
    }

    class MyClass2 : IIfc1
    {
        public void PrintOut(string s)
        {
            Console.WriteLine($"Call Through:{s}");
        }
    }
    /// <summary>
    /// 6.3 类引用转接口引用
    /// </summary>
    class CH0603
    {
        public CH0603()
        {
            MyClass2 mc = new MyClass2();
            mc.PrintOut("Object");
            IIfc1 ifc1 = (IIfc1)mc;
            ifc1.PrintOut("Interface");
        }
    }
}
