using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH06
{
    interface Iinfo
    {
        string GetName();
        string GetAge();
    }
    class CA:Iinfo
    {
        public string Name;
        public int Age;

        string Iinfo.GetAge()
        {
            return Age.ToString();
        }

        string Iinfo.GetName()
        {
            return Name;
        }
    }
    class CB:Iinfo
    {
        public string First;
        public string Last;
        public double PersonAge;

        string Iinfo.GetName()
        {
            return First + " " + Last;
        }

        string Iinfo.GetAge()
        {
            return PersonAge.ToString();
        }
    }
    /// <summary>
    /// 6.1 什么是接口：接口是一组函数成员而不实现他们的函数类型
    /// </summary>
    class CH0601
    {
        /// <summary>
        /// 无论该类什么结构，都能实现该方法
        /// </summary>
        /// <param name="iinfo"></param>
        static void PrintInfo(Iinfo iinfo)
        {
            Console.WriteLine($"Name:{iinfo.GetName()},Age:{iinfo.GetAge()}");
        }
        public CH0601()
        {
            CA ca = new CA { Age = 30, Name = "Johh Doe" };
            CB cb = new CB { First = "JOhh", Last = "Doe", PersonAge = 35 };
            PrintInfo(ca);
            PrintInfo(cb);
        }
    }
}
