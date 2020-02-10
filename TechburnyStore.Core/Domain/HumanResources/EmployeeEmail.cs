using System;

namespace TechburnyStore.Core.Domain.HumanResources
{
    public class EmployeeEmail : AuditableEntity
    {
        public int? ID { get; set; }

        public int? EmployeeID { get; set; }

        public string Email { get; set; }

    }
}