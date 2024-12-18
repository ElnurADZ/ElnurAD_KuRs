using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Department
    {
        public Department()
        {
            Offices = new HashSet<Office>();
        }

        public int IdDepartament { get; set; }
        public string Name { get; set; } = null!;
        public string Adress { get; set; } = null!;
        public int? EmployeCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Office> Offices { get; set; }
    }
}
