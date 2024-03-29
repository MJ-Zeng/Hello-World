﻿using System;
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
using CSharpAdvance.CH07;
using CSharpAdvance.CH08;
using CSharpAdvance.CH09;
using CSharpAdvance.CH10;

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
            Console.WriteLine("----------------------0602 IComparable实现sort排序：----------");
            CH0602 cH0602 = new CH0602();
            Console.WriteLine("----------------------0603 类引用转接口引用：-----------------");
            CH0603 cH0603 = new CH0603();
            Console.WriteLine("----------------------0604 隐式接口实现：---------------------");
            CH0604 cH0604 = new CH0604();
            Console.WriteLine("----------------------0605 显示接口实现：---------------------");
            CH0605 cH0605 = new CH0605();

            #endregion

            #region 07类型转换
            Console.WriteLine();
            Console.WriteLine("----------------------0701 转换溢出检测：------------------------");
            CH0701 ch0701 = new CH0701();
            Console.WriteLine("----------------------0702 引用转换：----------------------------");
            CH0702 ch0702 = new CH0702();
            Console.WriteLine("----------------------0703 装箱和拆箱：--------------------------");
            CH0703 ch0703 = new CH0703();
            Console.WriteLine("----------------------0701 is 和 as：---------------------------");
            CH0704 ch0704 = new CH0704();
            #endregion

            #region 08 泛型
            Console.WriteLine();
            Console.WriteLine("----------------------0801 泛型约束：------------------------");
            CH0801 ch0801 = new CH0801();
            Console.WriteLine("----------------------0802 泛型方法：------------------------");
            CH0802 ch0802 = new CH0802();
            Console.WriteLine("----------------------0803 泛型扩展方法：--------------------");
            CH0803 ch0803 = new CH0803();
            Console.WriteLine("----------------------0804 泛型委托：------------------------");
            CH0804 ch0804 = new CH0804();
            Console.WriteLine("----------------------0805 逆变和协变：------------------------");
            CH0805 ch0805 = new CH0805();
            #endregion

            #region 09 反射和特性
            Console.WriteLine();
            Console.WriteLine("----------------------0901 反射和元数据：------------------------");
            CH0901 ch0901 = new CH0901();
            Console.WriteLine("----------------------0901 自定义特性：--------------------------");
            CH0902 ch0902 = new CH0902();
            #endregion

            #region Lambda和Linq
            Console.WriteLine();
            Console.WriteLine("----------------------1001 Lambda表达式：------------------------");
            CH1001 ch1001 = new CH1001();
            Console.WriteLine("----------------------1002 Linq：--------------------------------");
            CH1002 ch1002 = new CH1002();
            #endregion

            Console.ReadKey();
        }
    }
}
