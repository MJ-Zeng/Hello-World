using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH08
{
    /*
     泛型扩展方法:
        1.必须声明为static
        2.必须是静态类的成员
        3.第一个参数类型中必须为this
     */

    class Hold<T>
    {
        T[] Vals = new T[3];
        public Hold(T V0,T V1,T V2)
        {
            Vals[0] = V0;
            Vals[1] = V1;
            Vals[2] = V2;
        }
        public T[] GetValues() { return Vals; }
    }

    //扩展方法
    static class HoldExtend
    {
        public static void Print<T>(this Hold<T> h)
        {
            T[] Vals = h.GetValues();
            Console.WriteLine("{0},\t{1}.\t{2}",Vals[0],Vals[1],Vals[2]);
        }
    }

    /// <summary>
    /// 8.3 泛型扩展方法
    /// </summary>
    class CH0803
    {
        public CH0803()
        {
            var intHolder = new Hold<int>(3, 5, 7);
            var strHolder = new Hold<string>("a", "b", "c" );
            intHolder.Print();
            strHolder.Print();
        }
    }
}
