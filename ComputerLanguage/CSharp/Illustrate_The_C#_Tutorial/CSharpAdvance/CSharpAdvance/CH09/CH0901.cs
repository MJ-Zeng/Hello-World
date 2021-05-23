using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH09
{
    /*
     元数据：有关程序及其类型的是数据称为元数据，它们保存在程序集中
     反射：可以查看运行时程序集的元数据
        
     */

    class BaseClass
    {
        public int BaseFiled = 0;
    }
    class DerivedClass : BaseClass
    {
        public int DerivedFiled = 0;
    }

    /// <summary>
    /// 反射和元数据
    /// </summary>
    class CH0901
    {
        public CH0901()
        {
            var bc = new BaseClass();
            var dc = new DerivedClass();
            BaseClass[] bca = new BaseClass[] { bc, dc };
            foreach (var v in bca)
            {
                Type t = v.GetType();   //获取类型
                Console.WriteLine($"object name:{t.Name}");

                FieldInfo[] fi = t.GetFields();  //反射获取字段信息
                foreach (var f in fi)
                {
                    Console.WriteLine($"Filed:{f.Name}");
                }
                Console.WriteLine();
            }
        }
    }
}
