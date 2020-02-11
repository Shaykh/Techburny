using System;

namespace TechburnyStore.Core.Domain
{
    public interface IAuditableEntity
    {
        string  CreationUser { get; set; }

        DateTime? CreationDateTime { get; set; }

        string  LastUpdateUser { get; set; }

        DateTime? LastUpdateDateTime { get; set; }

    }
}