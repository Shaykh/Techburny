using System;

namespace TechburnyStore.Core.Domain.HumanResources
{
    public class EmployeeAddress : AuditableEntity
    {
        public int? ID { get; set; }

        public int? EmployeeID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public int? CountryID { get; set; }

        public string PhoneNumber { get; set; }

    }
}