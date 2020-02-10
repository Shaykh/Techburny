using System;

namespace TechburnyStore.Core.Domain.Dbo
{
    public class CountryCurrency : AuditableEntity
    {
        public int? ID { get; set; }

        public int? CountryID { get; set; }

        public string CurrencyID { get; set; }

    }
}