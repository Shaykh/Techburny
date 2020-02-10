using System;

namespace TechburnyStore.Core.Domain
{
    public class AuditableEntity
    {
        string  CreationUser { get; set; }

        DateTime? CreationDateTime { get; set; }

        string  LastUpdateUser { get; set; }

        DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }
    }
}