using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH04
{
    //4.1 用户定义隐式和显式类型转换
    class LimitedIntOp
    {
        const int MaxValue = 100;
        const int MinValue = 0;
        //隐式转换：把li类型转换成int类型
        public static implicit operator int(LimitedIntOp li)
        {
            return li.TheValue;
        }
        public static implicit operator LimitedIntOp(int x)
        {
            LimitedIntOp Li = new LimitedIntOp();
            Li.TheValue = x;
            return Li;
        }
        private int _theValue;
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
    /// 用户定义隐/显式implict operator类型转换
    /// </summary>
    class CH0401
    {
        public CH0401()
        {
            LimitedIntOp li = 500; //int隐式转换LimitedInt
            int x = li;//Limited隐式转换成int
            Console.WriteLine($"li:{li.TheValue},x:{x}");
        }
    }
}
