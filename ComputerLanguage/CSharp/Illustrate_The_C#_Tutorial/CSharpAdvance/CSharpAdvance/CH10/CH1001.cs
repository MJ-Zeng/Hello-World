using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH10
{
    delegate void StuDel(string name, int age);
    public class LambdaClass
    {

        public void show()
        {
            //版本1
            {
                StuDel stuDel = new StuDel(Student);
                stuDel("委托调用", 1);
            }

            //版本2
            {
                StuDel stuDel = new StuDel(delegate(string name, int age)
                {
                    Console.WriteLine($"我的名字：{name},年龄：{age}");
                });
                stuDel("delegate+参数", 2);

            }

            //版本3：匿名方法
            {
                StuDel stuDel = new StuDel((string name, int age)=>
                {
                    Console.WriteLine($"我的名字：{name},年龄：{age}");
                });
                stuDel("匿名函数", 3);
            }
            {
                Action action = () => Console.WriteLine();
                Func<DateTime> func = () => { return DateTime.Now; };
            }
        }

        public void Student(string name,int age)
        {
            Console.WriteLine($"我的名字：{name},年龄：{age}");
        }
    }

    /// <summary>
    /// 10.1 Lambda表达式:本身就是一个匿名方法
    /// </summary>
    class CH1001
    {
        public CH1001()
        {
            LambdaClass lambdaClass = new LambdaClass();
            lambdaClass.show();
        }
    }
}
