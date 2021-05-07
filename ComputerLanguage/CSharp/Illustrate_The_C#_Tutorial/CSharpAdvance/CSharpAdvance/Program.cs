using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvance.CH01;
using CSharpAdvance.CH02;
using CSharpAdvance.CH03;
using CSharpAdvance.CH04;
using CSharpAdvance.CH05;
using CSharpAdvance.CH06;

namespace CSharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 01方法
            Console.WriteLine("----------------------值参数：----------------------------");
            CH0101 cH0101 = new CH0101();
            Console.WriteLine("----------------------REF参数：---------------------------");
            CH0102 cH0102 = new CH0102();
            Console.WriteLine("----------------------OUT参数：---------------------------");
            CH0103 cH0103 = new CH0103();
            Console.WriteLine("----------------------命名参数：--------------------------");
            CH0104 cH0104 = new CH0104();
            Console.WriteLine("----------------------可选参数：--------------------------");
            CH0105 cH0105 = new CH0105();
            #endregion

            #region 02类
            Console.WriteLine();
            Console.WriteLine("----------------------属性和字段关联：--------------------------");
            CH0201 cH0201 = new CH0201();
            Console.WriteLine("----------------------构造函数：--------------------------------");
            CH0202 cH0202 = new CH0202();
            Console.WriteLine("----------------------new初始化对象：---------------------------");
            CH0203 cH0203 = new CH0203();
            Console.WriteLine("----------------------this关键字：------------------------------");
            CH0204 cH0204 = new CH0204();
            Console.WriteLine("----------------------索引器：----------------------------------");
            CH0205 cH0205 = new CH0205();
            Console.WriteLine("----------------------分布类：----------------------------------");
            CH0206 cH0206 = new CH0206();
            #endregion

            #region 03类继承
            Console.WriteLine();
            Console.WriteLine("----------------------new屏蔽基类：---------------------------");
            CH0301 cH0301 = new CH0301();
            Console.WriteLine("----------------------base基类访问：--------------------------");
            CH0302 cH0302 = new CH0302();
            Console.WriteLine("----------------------派生类转换基类：-------------------------");
            CH0303 cH0303 = new CH0303();
            Console.WriteLine("----------------------构造函数+base+this：---------------------");
            CH0304 cH0304 = new CH0304();
            Console.WriteLine("------------------------扩展方法：-----------------------------");
            CH0305 cH0305 = new CH0305();
            #endregion

            #region 04运算符和表达式
            Console.WriteLine();
            Console.WriteLine("----------------------自定义隐、显式转换：------------------------");
            CH0401 cH0401 = new CH0401();
            Console.WriteLine("----------------------自定义运算符重载：--------------------------");
            CH0402 cH0402 = new CH0402();
            #endregion

            #region 05委托
            Console.WriteLine();
            Console.WriteLine("----------------------委托入门：------------------------");
            CH0501 cH0501 = new CH0501();
            Console.WriteLine("----------------------委托理解：------------------------");
            CH0502 cH0502 = new CH0502();
            Console.WriteLine("----------------------委托与冒泡排序：-------------------");
            CH0503 cH0503 = new CH0503();
            Console.WriteLine("----------------------泛型委托+action+Func：-------------");
            CH0504 cH0504 = new CH0504();
            Console.WriteLine("----------------------多播委托：-------------------------");
            CH0505 cH0505 = new CH0505();
            #endregion

            #region 06接口
            Console.WriteLine();
            Console.WriteLine("----------------------0601什么是接口：------------------------");
            CH0601 cH0601 = new CH0601();

            #endregion

            Console.ReadKey();
        }
    }
}
