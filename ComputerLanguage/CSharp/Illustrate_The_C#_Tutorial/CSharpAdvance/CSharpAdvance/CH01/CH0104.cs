using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH01
{
    /// <summary>
    /// 1.4 命名参数：只要显示指定参数的名字，就可以任意顺序调出实参
    /// </summary>
    class CH0104
    {
        public int Calc(int a, int b, int c) { return (a + b) * c; }
        public CH0104()
        {
            Program pg = new Program();
            int r0 = Calc(4, 3, 2);
            int r1 = Calc(c: 2, b: 2 + 1, a: 4);
            Console.WriteLine($"r0={r0},r1={r1}");
            #region result
            //r0=14,r1=14
            #endregion

        }
    }
}
