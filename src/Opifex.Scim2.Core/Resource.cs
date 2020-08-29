using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Opifex.Scim2.Core
{
    public class Resource<TKey> where TKey : IKey
    {
        public TKey Id { get; }

        public string ExternalId { get; }

        public virtual IEnumerable<Uri> Schemas { get; }

        public ScimMetadata Meta { get; }
    }
}
