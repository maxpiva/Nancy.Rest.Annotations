using System;

namespace Nancy.Rest.Annotations.Atributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class Ignore : Attribute
    {
    }
}
