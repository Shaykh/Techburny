using System;

namespace TechburnyStore.Core.Domain.HumanResources
{
    public class Employee : AuditableEntity
    {
        public int? ID { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public DateTime? BirthDate { get; set; }

        public Employee()
        {
        }

        public Employee(int? id)
        {
            ID = id;
        }
    }
}