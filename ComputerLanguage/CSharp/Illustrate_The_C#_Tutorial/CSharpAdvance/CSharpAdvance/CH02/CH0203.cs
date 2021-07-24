using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH02
{
    public class Point
    {
        public int x = 1;
        public int y = 2;
    }

    /// <summary>
    /// 2.3 对象初始化
    /// </summary>
    class CH0203
    {
        public CH0203()
        {
            Point pt1 = new Point();
            Point pt2 = new Point { x = 5, y = 6 };//构造函数设置为x=1,y=2;再初始化为x=5,y=6
            Console.WriteLine($"pt1:{pt1.x},{pt1.y}");
            Console.WriteLine($"pt2:{pt2.x},{pt2.y}");
        }
    }
}
