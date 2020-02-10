using System;

namespace TechburnyStore.Core.Domain.Dbo
{
    public class EventLog
    {
        public int? ID { get; set; }

        public int? EventType { get; set; }

        public string Key { get; set; }

        public string Message { get; set; }

        public DateTime? EntryDate { get; set; }
    }
}