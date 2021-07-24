using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH02
{
    class Class1
    {
        int Id;
        string Name;
        public Class1() { Id = 28; Name = "Nemo"; }
        public Class1(int val) { Id = val; Name = "Nemo"; }
        public Class1(string name) { Id = 28; Name = name; }
        public void SoundOff()
        {
            Console.WriteLine($"Name:{Name},Id:{Id}");
        }

    }
    /// <summary>
    /// 2.2 构造函数：实例化时调用
    /// </summary>
    class CH0202
    {
        public CH0202()
        {
            Class1 a = new Class1(),
                   b = new Class1(7),
                   c = new Class1("Bill");
            a.SoundOff();
            b.SoundOff();
            c.SoundOff();
        }
    }
}
