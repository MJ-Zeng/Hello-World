using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH01
{
    /// <summary>
    /// 1.5 可选参数
    /// </summary>
    class CH0105
    {
        public int Calc(int a = 2, int b = 3, int c = 4) { return (a + b) * c; }
        public CH0105()
        {
            Program pg = new Program();
            int r0 = Calc();
            int r1 = Calc(5);
            int r2 = Calc(5, 6);
            int r3 = Calc(5, 6, 7);
            Console.WriteLine($"r0={r0},r1={r1},r2={r2},r3={r3}");

        }
    }
}
