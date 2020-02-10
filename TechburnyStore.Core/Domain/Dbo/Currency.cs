using System;

namespace TechburnyStore.Core.Domain.Dbo
{
    public class Currency : AuditableEntity
    {
        public string ID { get; set; }

        public string CurrencyName { get; set; }

        public string CurrencySymbol { get; set; }

    }
}