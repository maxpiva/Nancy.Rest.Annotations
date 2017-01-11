using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.Rest.Annotations
{
    [AttributeUsage(AttributeTargets.Property|AttributeTargets.Field)]
    public class Level : Attribute
    {
        public int Value { get; set; }

        public Level(int value)
        {
            Value = value;
        }
    }
}
