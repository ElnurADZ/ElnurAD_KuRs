using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Vacation
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int Year { get; set; }
        public int Remain { get; set; }
        public int Used { get; set; }
        public DateTime BeginningVacations { get; set; }
        public DateTime EndVacations { get; set; }
        public int IdVacations { get; set; }
        public int? IdEmloyee { get; set; }

        public virtual Employee? IdEmloyeeNavigation { get; set; }
    }
}
