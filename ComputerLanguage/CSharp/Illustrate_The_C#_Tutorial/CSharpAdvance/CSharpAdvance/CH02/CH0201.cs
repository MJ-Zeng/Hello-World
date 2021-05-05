using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH02
{

    class C1
    {
        private int TheRealValue = 10;
        public int MyValue
        {
            get { return TheRealValue; }
            set { TheRealValue = value; }
        }
    }
    /// <summary>
    /// 属性和字段关联:通过属性来扩展字段
    /// </summary>
    class CH0201
    {
        public CH0201()
        {
            C1 C = new C1();
            Console.WriteLine($"MyValue:{C.MyValue}");
            C.MyValue = 20;
            Console.WriteLine($"MyValue:{C.MyValue}");
        }
    }
}
