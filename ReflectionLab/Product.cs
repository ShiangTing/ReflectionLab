using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLab
{
    [CustomNameAttribute("名稱")]
    public class Product
    {
        [CustomNameAttribute("名稱")]
        public string Name { get; set; }

        [CustomNameAttribute("代碼")]
        public string Code { get; set; }
    }
}
