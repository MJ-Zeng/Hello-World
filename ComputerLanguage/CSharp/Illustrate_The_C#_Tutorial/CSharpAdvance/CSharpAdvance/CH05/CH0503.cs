using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH05
{
    /// <summary>
    /// 委托与冒泡排序
    /// </summary>
    class CH0503
    {
        public CH0503()
        {
            int[] arrs = new int[] { 1, 4, 5, 21, 9, 3, 2 };
            SortThan sortThan = new SortThan(Compare2);
            DelegateSort.BubbleSort(arrs, sortThan);
            foreach (var item in arrs)
            {
                Console.WriteLine($"{item}");
            }
        }
        //顺序排序
        public static bool Compare(int x, int y)
        {
            return x > y;
        }

        //逆序排序
        public static bool Compare2(int x, int y)
        {
            return x < y;
        }
    }
}
