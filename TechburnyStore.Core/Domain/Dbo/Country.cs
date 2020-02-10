using System;

namespace TechburnyStore.Core.Domain.Dbo
{
    public class Country : AuditableEntity
    {
        public int? ID { get; set; }

        public string  CountryName { get; set; }

    }
}