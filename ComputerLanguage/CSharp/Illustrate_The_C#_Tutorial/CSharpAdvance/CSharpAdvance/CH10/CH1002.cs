using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH10
{
    public class Stu
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
    class Linq
    {
        public void show()
        {
            List<Stu> stus = new List<Stu>
            {
                new Stu { Name = "A", Age = 1 },
                new Stu { Name = "B", Age = 2 },
                new Stu { Name = "C", Age = 3 },
                new Stu { Name = "D", Age = 4 },
                new Stu { Name = "E", Age = 5 },
                new Stu { Name = "F", Age = 6 },
                new Stu { Name = "G", Age = 7 },
                new Stu { Name = "H", Age = 8 }
            };
            {
                //普通查询
                foreach (var item in stus)
                {
                    if (item.Age < 5)
                    {
                        Console.WriteLine($"Name:{item.Name},Age{item.Age}");
                    }
                }
            }
            {
                Console.WriteLine("linq表达式");
                var list = from x in stus where x.Age < 5 select x;
                foreach (var item in list)
                {
                    if (item.Age < 5)
                    {
                        Console.WriteLine($"Name:{item.Name},Age{item.Age}");
                    }
                }
            }
            {
                //Linq--扩展方法
                Console.WriteLine("Linq--扩展方法");
                var list = stus.Where(x => x.Age < 5);
                foreach (var item in list)
                {
                    if (item.Age < 5)
                    {
                        Console.WriteLine($"Name:{item.Name},Age{item.Age}");
                    }
                }
            }
            {
                //Linq--自定义
                Console.WriteLine("Linq--自定义方法");
                var list = stus.MyWhere(x => x.Age < 5);
                foreach (var item in list)
                {
                    if (item.Age < 5)
                    {
                        Console.WriteLine($"Name:{item.Name},Age{item.Age}");
                    }
                }
            }
        }
    }

    /// <summary>
    /// 自定义Linq
    /// </summary>
    public static class ExtendLinq
    {
        public static List<Stu> MyWhere(this List<Stu> stus,Func<Stu,bool> func)
        {
            var list = new List<Stu>();
            foreach (var item in stus)
            {
                if (func.Invoke(item))
                {
                    list.Add(item);
                }
            }
            return list;
        }
    } 

    /// <summary>
    /// 什么是LINQ:集成语言查询的快捷方式
    /// </summary>
    class CH1002
    {
        public CH1002()
        {
            Linq linq = new Linq();
            linq.show();
        }
    }
}
