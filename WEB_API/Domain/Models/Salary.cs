using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Salary
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public double Money { get; set; }
        public int Year { get; set; }
        public int Month { get; set; }
        public int IdSalary { get; set; }
        public int? IdEmloyee { get; set; }

        public virtual Employee? IdEmloyeeNavigation { get; set; }
    }
}
