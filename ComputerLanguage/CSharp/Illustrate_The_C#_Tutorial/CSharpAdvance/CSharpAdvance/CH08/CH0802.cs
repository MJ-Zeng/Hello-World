using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH08
{
    class Simple
    {
        static public void ReverseAndPrint<T>(T[] arr)
        {
            Array.Reverse(arr);
            foreach (var item in arr)
            {
                Console.Write(item.ToString()+" ");
            }
            Console.WriteLine("");
        }
    }

    /// <summary>
    /// 泛型方法
    /// </summary>
    class CH0802
    {
        public CH0802()
        {
            var intArr = new int[] { 3, 5, 7, 9, 11 };
            var strArr = new string[] { "first", "second", "third" };
            var doubleArr = new double[] { 3.567, 7.891, 2.345 };
            Simple.ReverseAndPrint<int>(intArr);//直接调用
            Simple.ReverseAndPrint(intArr);     //推断类型调用
            Simple.ReverseAndPrint<string>(strArr);
            Simple.ReverseAndPrint(strArr);
            Simple.ReverseAndPrint<double>(doubleArr);
            Simple.ReverseAndPrint(doubleArr);
        }
    }
}
