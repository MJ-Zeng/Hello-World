using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH07
{
    /// <summary>
    /// 7.1 类型转换溢出检测：Checked UnChecked
    /// </summary>
    class CH0701
    {
        public CH0701()
        {
            ushort sh = 2000;
            byte sb;
            sb = unchecked((byte)sh);
            Console.WriteLine($"unchecked:{sb}");
            try
            {
                sb = checked((byte)sh);
                Console.WriteLine($"checked:{sb}");

            }
            catch (Exception ex)
            {

               
            }
            finally
            {
                Console.WriteLine("转换溢出");
            }

        }

    }
}
