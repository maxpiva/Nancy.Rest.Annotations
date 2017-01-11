using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.Rest.Annotations
{
    [AttributeUsage(AttributeTargets.Method)]
    public class Rest : Attribute
    {
        public Verbs Verb { get; set; }
        public string Route { get; set; }
        public string ResponseContentType { get; set; }

        public Rest(string route, Verbs verb, string contentype = null)
        {
            Verb = verb;
            Route = route;
            ResponseContentType = contentype;
        }
    }
}
