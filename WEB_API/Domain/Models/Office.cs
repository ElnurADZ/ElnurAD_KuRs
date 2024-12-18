using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Office
    {
        public Office()
        {
            Employees = new HashSet<Employee>();
            OfficeAds = new HashSet<OfficeAd>();
            OfficeCapitals = new HashSet<OfficeCapital>();
            OrderClients = new HashSet<OrderClient>();
            ReportClients = new HashSet<ReportClient>();
            IdPartners = new HashSet<Partner>();
        }

        public int IdDepartament { get; set; }
        public int IdOffice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? EmployeCount { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public string City { get; set; } = null!;

        public virtual Department IdDepartamentNavigation { get; set; } = null!;
        public virtual MethodConnection? MethodConnection { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<OfficeAd> OfficeAds { get; set; }
        public virtual ICollection<OfficeCapital> OfficeCapitals { get; set; }
        public virtual ICollection<OrderClient> OrderClients { get; set; }
        public virtual ICollection<ReportClient> ReportClients { get; set; }

        public virtual ICollection<Partner> IdPartners { get; set; }
    }
}
