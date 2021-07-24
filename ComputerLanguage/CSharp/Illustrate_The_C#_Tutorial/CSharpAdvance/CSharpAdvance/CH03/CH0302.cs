using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH03
{
    class SomeClass2
    {
        public string Field1 = "Field--In base class";

    }
    class OtherClass2 : SomeClass2
    {
        new public string Field1 = "Field--In drieved class";
        public void PrintFiled1()
        {
            Console.WriteLine(Field1);
            Console.WriteLine(base.Field1);
        }
    }

    /// <summary>
    /// 3.2 base:访问基类
    /// </summary>
    class CH0302
    {
        public CH0302()
        {
            OtherClass2 oc = new OtherClass2();
            oc.PrintFiled1();
        }
    }
}
