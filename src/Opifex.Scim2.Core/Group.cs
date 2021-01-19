using System.Collections.Generic;

namespace Opifex.Scim2.Core
{
    public class Group<TKey, T2Key> : Resource<TKey>
        where TKey : IKey
        where T2Key : IKey
    {
        public string DisplayName { get; }

        public List<User<T2Key>> Members { get; }
    }
}
