using System;
using System.Collections.Generic;
using System.Text;

namespace ReflectionLab
{
    public class CustomNameAttribute : Attribute
    {
        private string name;

        public CustomNameAttribute(string name)
        {
            this.name = name;
        }
        public virtual string Name
        {
            get { return name; }
        }
    }
}
