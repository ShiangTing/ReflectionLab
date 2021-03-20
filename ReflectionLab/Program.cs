using System;
using System.Linq;
using System.Reflection;

namespace ReflectionLab
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            GetAttribute(typeof(Product));
            //var props = typeof(Product).GetProperties().Where(prop => Attribute.IsDefined(prop, typeof(CustomNameAttribute)));
            //foreach (var prop in props)
            //{
            //    string value = prop.GetAttributValue((CustomNameAttribute a) => a.Name);
            //}
        }
        public static void GetAttribute(Type t)
        {
            PropertyInfo[] propertys = typeof(Product).GetProperties();
            if (propertys != null && propertys.Length > 0)
            {
                foreach (PropertyInfo p in propertys)
                {
                    var objAttrs = p.GetCustomAttribute(typeof(CustomNameAttribute), true);//获取自定义特性
                    //GetCustomAttributes(要搜索的特性类型，是否搜索该成员的继承链以查找这些特性)
                    var c = objAttrs.GetType();
                    Console.WriteLine(objAttrs.GetType().GetProperties().Where(x=>x.Name=="Name"));
                    //if (objAttrs != null && objAttrs.Length > 0)
                    //{
                    //    CustomNameAttribute attr = objAttrs[0] as CustomNameAttribute;
                    //    Console.WriteLine("自定義屬性：" + p.Name + ", 屬性value：" + attr.Name);
                    //}
                };
            }
        }

    }
}
