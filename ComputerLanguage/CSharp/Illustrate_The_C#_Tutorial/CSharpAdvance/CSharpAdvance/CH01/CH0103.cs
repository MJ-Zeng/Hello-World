using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH01
{
    /// <summary>
    /// 1.3 out输出参数
    /// </summary>
    class CH0103
    {
        static void MyMethod(out MyClass f1, out int f2)
        {
            f1 = new MyClass();
            f1.val = 25;
            f2 = 15;
            Console.WriteLine($"f1.val={f1.val},f2={f2}");
        }
        public CH0103()
        {
            MyClass a1 = null;
            int a2;
            MyMethod(out a1, out a2);
            Console.WriteLine($"a1.val={a1.val},a2={a2}");

            #region result  
            //out输出的是方法内修改后的值           
            //f1.val=25,f2=15
            //a1.val=25,a2=15        
            #endregion

        }
    }
}
