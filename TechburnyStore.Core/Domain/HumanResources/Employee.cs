using System;

namespace TechburnyStore.Core.Domain.HumanResources
{
    public class Employee : IAuditableEntity
    {
        public int? ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public string  CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string  LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }

        public Employee()
        {
        }

        public Employee(int? id)
        {
            ID = id;
        }
    }
}