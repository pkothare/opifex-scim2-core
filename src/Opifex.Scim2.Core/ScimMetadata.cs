using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Opifex.Scim2.Core
{
    public class ScimMetadata
    {
        public string ResourceType { get; }

        public DateTimeOffset Created { get; }

        public DateTimeOffset LastModified { get; }

        public Uri Location { get; }

        public string Version { get; }
    }
}
