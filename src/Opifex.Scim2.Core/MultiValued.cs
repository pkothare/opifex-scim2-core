namespace Opifex.Scim2.Core
{
    public class MultiValued<T>
    {
        public T Value { get; }

        public string Display { get; }

        public string Type { get; }

        public bool Primary { get; }
    }
}
