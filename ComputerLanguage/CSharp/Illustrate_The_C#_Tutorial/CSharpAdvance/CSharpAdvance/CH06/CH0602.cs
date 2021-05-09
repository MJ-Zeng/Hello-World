using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH06
{
    class MyClass:IComparable
    {
        public int TheValue;

        public int CompareTo(object obj)
        {
            MyClass mc = (MyClass)obj;
            if (this.TheValue < mc.TheValue) return -1;
            if (this.TheValue > mc.TheValue) return 1;
            return 0;


        }
    }
    /// <summary>
    /// 接口：Sort排序
    /// </summary>
    class CH0602
    {
        void PrintOut(string s,MyClass [] mc)
        {
            Console.WriteLine(s);
            foreach (var item in mc)
            {
                Console.WriteLine($"{item.TheValue}");
            }
            Console.WriteLine("");
        }
        public CH0602()
        {
            var myInt = new int[] { 20, 16, 9, 4, 2 };
            MyClass[] mcs = new MyClass[5]; 
            for (int i = 0; i < 5; i++)
            {
                mcs[i] = new MyClass();
                mcs[i].TheValue = myInt[i];
            }
            PrintOut("Initial Arr:", mcs);
            Array.Sort(mcs);
            PrintOut("Sort:", mcs);
        }
    }
}
