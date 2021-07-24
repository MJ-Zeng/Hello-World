using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH02
{


    class Employee
    {
        public string LastName;
        public string FirstName;
        public string CityOfBirth;
        //设置索引器
        public string this[int index]
        {
            set
            {
                switch (index)
                {
                    case 0: LastName = value; break;
                    case 1: FirstName = value; break;
                    case 2: CityOfBirth = value; break;
                    default:
                        throw new ArgumentException("index");

                }
            }
            get
            {
                switch (index)
                {
                    case 0: return LastName;
                    case 1: return FirstName;
                    case 2: return CityOfBirth;
                    default:
                        throw new ArgumentException("index");

                }
            }
        }
    }
    /// <summary>
    /// 2.5 索引器：设置索引，通过索引访问类的字段
    /// </summary>
    class CH0205
    {
        public CH0205()
        {
            Employee ep = new Employee() { LastName = "a", FirstName = "b", CityOfBirth = "c" };
            Console.WriteLine($"Values:{ep[0]},{ep[1]},{ep[2]}");
        }
    }
}
