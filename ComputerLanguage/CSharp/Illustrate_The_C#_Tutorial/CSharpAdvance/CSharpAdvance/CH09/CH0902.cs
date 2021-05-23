
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvance.CH09
{
    /*
     特性本质其实是调用某一特定功能的类
     */

    [AttributeUsage(AttributeTargets.Class|AttributeTargets.Method,AllowMultiple =true,Inherited =false)]
    public class DefinedAttribute : Attribute
    {
        public DefinedAttribute(string str)
        {
            _str = str;
        }
        public string _str;
    }

    [Defined("这是自定义的特性")]
    class UseAttribute
    {

    }
    /// <summary>
    /// 自定义特性
    /// </summary>
    class CH0902
    {
        public CH0902()
        {
            Type t = typeof(UseAttribute);
            object[] attrs = t.GetCustomAttributes(true);//找出所有特性
            foreach (var item in attrs)
            {
                DefinedAttribute definedAttribute = item as DefinedAttribute;
                if (definedAttribute != null)
                {
                    Console.WriteLine(definedAttribute._str);
                }
            }
        }
    }
}
