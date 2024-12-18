using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class ReportClient
    {
        public int IdOrderClients { get; set; }
        public int? IdFeedback { get; set; }
        public int IdReportClient { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public int? IdOfficeCapital { get; set; }
        public int? IdOffice { get; set; }

        public virtual Feedback? IdFeedbackNavigation { get; set; }
        public virtual OfficeCapital? IdOfficeCapitalNavigation { get; set; }
        public virtual Office? IdOfficeNavigation { get; set; }
        public virtual OrderClient IdOrderClientsNavigation { get; set; } = null!;
    }
}
