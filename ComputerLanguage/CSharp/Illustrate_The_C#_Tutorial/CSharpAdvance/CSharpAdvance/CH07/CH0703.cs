using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH07
{
    /*
     装箱：装箱是一种隐式转换，
          将值类型转换为引用类型
          本质是创建了一个值类型引用副本
     
    拆箱：1.显式转换
           2.将引用类型转换为值类型
           3.把对象的值复制给变量
           
     */

    /// <summary>
    /// 装箱
    /// </summary>
    class Box
    {
        public Box()
        {
            int i = 10;
            object oi = i;//创建并初始化引用类型
            Console.WriteLine($"i:{i},oi:{oi}");

            i = 12;
            oi = 15;
            Console.WriteLine($"i:{i},oi:{oi}");


        }

    }

    /// <summary>
    /// 拆箱
    /// </summary>
    class UnBox
    {
        public UnBox()
        {
            int i = 10;
            object oi = i;//创建并初始化引用类型
            int j = (int)oi;
            Console.WriteLine($"i:{i},j:{j},oi:{oi}");
        }
    }
    /// <summary>
    /// 7.3  装箱和拆箱
    /// </summary>
    class CH0703
    {
        Box Box = new Box();
        UnBox UnBox = new UnBox();
    }
}
