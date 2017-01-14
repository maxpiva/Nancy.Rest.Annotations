using System.Collections.Generic;

namespace Nancy.Rest.Annotations.Interfaces
{
    public interface IFilter<T>
    {
        T FilterWithLevel(int level);

        T FilterWithTags(IEnumerable<string> tags);

        T FilterWithLevelAndTags(int level, IEnumerable<string> tags);

    }
}
