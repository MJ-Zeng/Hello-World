using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH05
{
    delegate void MyDel(string msg); //定义委托
    /// <summary>
    /// 5.1 委托入门:委托是持有一个或多个方法的对象
    /// </summary>
    class CH0501
    {
        public CH0501()
        {
            MyDel myDel = new MyDel(Hello); //创建委托实例
            myDel("我是一个委托");    //调用委托
        }
        public static void Hello(string str)
        {
            Console.WriteLine($"{str}");
        }
    }
}
