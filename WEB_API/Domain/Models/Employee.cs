using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Salaries = new HashSet<Salary>();
            Vacations = new HashSet<Vacation>();
        }

        public int IdOffice { get; set; }
        public int IdEmloyee { get; set; }
        public string Post { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Fio { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Parol { get; set; } = null!;

        public virtual Office IdOfficeNavigation { get; set; } = null!;
        public virtual ICollection<Salary> Salaries { get; set; }
        public virtual ICollection<Vacation> Vacations { get; set; }
    }
}
