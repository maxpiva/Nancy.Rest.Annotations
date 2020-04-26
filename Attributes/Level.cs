using System;

namespace Nancy.Rest.Annotations.Attributes
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
