using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.Rest.Annotations
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
