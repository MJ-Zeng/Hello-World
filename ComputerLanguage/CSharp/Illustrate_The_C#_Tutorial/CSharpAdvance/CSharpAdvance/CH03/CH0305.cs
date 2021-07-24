using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH03
{
    sealed class MyData
    {
        private double D1, D2, D3;
        public MyData(double d1, double d2, double d3)
        {
            D1 = d1;
            D2 = d2;
            D3 = d3;
        }
        public double Sum()
        {
            return D1 + D2 + D3;
        }
    }

    //静态类的扩展方法
    static class MyDataExtend
    {
        public static double Avg(this MyData md)
        {
            return md.Sum() / 3;
        }
    }
    /// <summary>
    /// 3.5 静态扩展方法
    /// </summary>
    class CH0305
    {
        public CH0305()
        {
            MyData md = new MyData(3, 4, 5);
            Console.WriteLine($"Sum:{md.Sum()}");
            Console.WriteLine($"Avg:{md.Avg()}");
        }

    }
}
