using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Feedback
    {
        public Feedback()
        {
            ReportClients = new HashSet<ReportClient>();
        }

        public int? IdClients { get; set; }
        public int IdFeedback { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Text { get; set; } = null!;
        public bool Recommendation { get; set; }

        public virtual Client? IdClientsNavigation { get; set; }
        public virtual ICollection<ReportClient> ReportClients { get; set; }
    }
}
