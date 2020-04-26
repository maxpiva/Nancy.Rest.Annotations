using System;

namespace Nancy.Rest.Annotations.Attributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class Ignore : Attribute
    {
    }
}
