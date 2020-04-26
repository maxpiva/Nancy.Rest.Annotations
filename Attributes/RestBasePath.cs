using System;

namespace Nancy.Rest.Annotations.Attributes
{
    [AttributeUsage(AttributeTargets.Interface|AttributeTargets.Class)]
    public class RestBasePath : Attribute
    {
        public string BasePath { get; set; }

        public RestBasePath(string basepath)
        {
            BasePath = basepath;
        }
    }
}
