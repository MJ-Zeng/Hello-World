using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH02
{

    class MyClass
    {
        int Var1 = 10;
        public int ReturnMax(int Var1)
        {
            return Var1 > this.Var1 ? Var1 : this.Var1;
        }
    }
    /// <summary>
    /// 2.4 this关键字:用于区分类的成员和本地关键字
    /// </summary>
    class CH0204
    {
        public CH0204()
        {
            MyClass mc = new MyClass();
            Console.WriteLine($"max:{mc.ReturnMax(30)}");
            Console.WriteLine($"max:{mc.ReturnMax(5)}");

        }
    }
}
