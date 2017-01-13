using System;

namespace Nancy.Rest.Annotations.Atributes
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
