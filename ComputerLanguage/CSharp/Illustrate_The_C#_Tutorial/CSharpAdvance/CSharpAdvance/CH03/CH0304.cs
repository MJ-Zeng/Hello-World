using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH03
{
    /// <summary>
    /// 3.4 构造函数中的base和this
    /// </summary>
    class BaseClass
    {
        public BaseClass()
        {
            Console.WriteLine("--基类无参数构造函数--");
        }
        public BaseClass(string name)
        {
            Console.WriteLine($"{name}--基类string构造函数--");
        }


    }
    class DerivedClass : BaseClass
    {
        public DerivedClass()
            : base()
        {

        }
        /// <summary>
        /// base():是让子类来调用父类中构造方法
        /// </summary>
        /// <param name="name"></param>
        public DerivedClass(string name)
            : base(name)
        {
            
        }
        /// <summary>
        /// this():首先说明只能在自己类中使用，也就是说多个构造函数时，想调用同类中的另一个构造函数时就可以用this
        /// </summary>
        public DerivedClass(int i)
        {
            Console.WriteLine($"this:{i}");
        }
        public DerivedClass(int x,int y) : this(5)
        {

        }
    }
    /// <summary>
    /// 构造函数+base+this
    /// </summary>
    class CH0304
    {
        DerivedClass dc = new DerivedClass();   //调用基类无参数构造函数
        DerivedClass dc2 = new DerivedClass("base");//调用基类有参数构造函数
        DerivedClass dc3 = new DerivedClass(5);
    }
}
