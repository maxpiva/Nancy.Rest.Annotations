using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nancy.Rest.Annotations
{
    public interface ILevel<T>
    {
        T Level(int level);
    }
}
