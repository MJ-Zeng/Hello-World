using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH01
{
    /// <summary>
    /// 1.2ref引用参数
    /// </summary>
    class CH0102
    {
        //ref表引用
        static void MyMethod(MyClass f1, ref int f2)
        {
            f1.val = f1.val + 5;
            f2 += 5;
            Console.WriteLine($"f1.val={f1.val},f2={f2}");
        }
        public CH0102()
        {
            MyClass a1 = new MyClass();
            int a2 = 10;
            MyMethod(a1, ref a2);
            Console.WriteLine($"a1.val={a1.val},a2={a2}");

            #region result  
            //MyClass是引用传递，a2是引用传递           
            //f1.val=25,f2=15
            //a1.val=25,a2=15        
            #endregion

        }
    }
}
