using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH03
{
    class SomeClass
    {
        public string Fileld1 = "some class field ";
        public void Method1(string value)
        {
            Console.WriteLine($"SomeClass Method1:{value}");
        }
    }
    class OtherClass : SomeClass
    {
        new public string Fileld1 = "otherclass field1";
        new public void Method1(string value)
        {
            Console.WriteLine($"OtherClass Method1:{value}");

        }
    }

    /// <summary>
    /// 3.1 new关键字：屏蔽基类成员
    /// </summary>
    class CH0301
    {
        public CH0301()
        {
            OtherClass oc = new OtherClass();
            oc.Method1(oc.Fileld1);
        }
    }
}
