using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH05
{
    delegate bool SortThan(int x, int y);
    class DelegateSort
    {

        public static void BubbleSort(int[] arr, SortThan sortThan)
        {
            int i, j, t;
            if (arr == null) return;
            for (i = arr.Length - 1; i > 0; i--)
            {
                for (j = 1; j <= i; j++)
                {
                    if (sortThan(arr[j - 1], arr[j]))
                    {
                        t = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = t;
                    }
                }
            }

        }
    }
}
