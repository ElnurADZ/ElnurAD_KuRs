using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OfficeCapital
    {
        public OfficeCapital()
        {
            ReportClients = new HashSet<ReportClient>();
        }

        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public double OldCapital { get; set; }
        public double NewCapital { get; set; }
        public int IdOfficeCapital { get; set; }
        public int? IdOffice { get; set; }

        public virtual Office? IdOfficeNavigation { get; set; }
        public virtual ICollection<ReportClient> ReportClients { get; set; }
    }
}
