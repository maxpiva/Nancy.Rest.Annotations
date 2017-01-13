using System.Collections.Generic;

namespace Nancy.Rest.Annotations.Interfaces
{
    public interface IFilter<T>
    {
        T Filter(int level, IEnumerable<string> tags = null);
    }
}
