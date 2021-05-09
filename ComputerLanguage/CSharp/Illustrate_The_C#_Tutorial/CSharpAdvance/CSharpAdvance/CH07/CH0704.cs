using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH07
{
    /*
     is:只能用于引用类型转换，不能用于自定义转换

     as:和强制类型转换类似，若转换失败不会抛出异常
     
     */
    class Person
    {
        public string Name = "Anonymous";
        public int Age = 25;
    }
    class Employee:Person
    {

    }

    /// <summary>
    /// is 和 as转换
    /// </summary>
    class CH0704
    {
        public CH0704()
        {
            Employee bill = new Employee();
            Person p,q;
            if(bill is Person)
            {
                p = bill;
                Console.WriteLine($"is :{p.Name},{p.Age}");
            }

            q = bill as Person;
            if (q != null)
            {
                Console.WriteLine($"as:{q.Name},{q.Age}");

            }
        }
    }
}
