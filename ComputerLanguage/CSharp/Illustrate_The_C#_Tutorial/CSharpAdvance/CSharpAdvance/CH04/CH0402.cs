using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH04
{
    //运算符重载：操作自定义类型的操作数，适用于类和结构类型
    class LimitedInt
    {
        const int MaxValue = 100;
        const int MinValue = 0;

        //-一元操作符
        public static LimitedInt operator -(LimitedInt x)
        {
            LimitedInt li = new LimitedInt();
            li.TheValue = 0;
            return li;
        }
        //二元操作符
        public static LimitedInt operator -(LimitedInt x, LimitedInt y)
        {
            LimitedInt li = new LimitedInt();
            li.TheValue = x.TheValue - y.TheValue;
            return li;
        }
        public static LimitedInt operator +(LimitedInt x, double y)
        {
            LimitedInt li = new LimitedInt();
            li.TheValue = x.TheValue + (int)y;
            return li;
        }
        private int _theValue = 0;
        public int TheValue
        {
            get { return _theValue; }
            set
            {
                if (value < MinValue)
                {
                    _theValue = 0;
                }
                else
                {
                    _theValue = value > MaxValue ? MaxValue : value;
                }
            }

        }

    }
    /// <summary>
    /// 自定义运算符重载  operator +
    /// </summary>
    class CH0402
    {
        public CH0402()
        {
            LimitedInt li1 = new LimitedInt();
            LimitedInt li2 = new LimitedInt();
            LimitedInt li3 = new LimitedInt();
            li1.TheValue = 10;
            li2.TheValue = 26;
            Console.WriteLine($"l11:{li1.TheValue},li2:{li2.TheValue}");
            li3 -= li1;
            Console.WriteLine($"l11:{li1.TheValue},li3:{li3.TheValue}");
            li3 = li1 - li2;
            Console.WriteLine($"{li1.TheValue}-{li2.TheValue}={li3.TheValue}");
        }
    }
}
