using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH02
{


    partial class MyClasspart
    {
        //定义部分
        partial void PrintSum(int x, int y);
        public void Add(int x, int y)
        {
            PrintSum(x, y);
        }
    }
    partial class MyClasspart
    {
        partial void PrintSum(int x, int y)
        {
            Console.WriteLine($"Sum is {x + y}");
        }
    }
    /// <summary>
    /// 2.6 分布类
    /// </summary>
    class CH0206
    {
        public CH0206()
        {
            var mc = new MyClasspart();
            mc.Add(5, 6);
            
        }
    }
}
