using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OrderClient
    {
        public OrderClient()
        {
            ReportClients = new HashSet<ReportClient>();
        }

        public int IdClients { get; set; }
        public int IdOffice { get; set; }
        public int IdOrderClients { get; set; }
        public string Text { get; set; } = null!;
        public DateTime Term { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public double ConvenientPrice { get; set; }
        public bool? Paid { get; set; }
        public string? Wish { get; set; }

        public virtual Client IdClientsNavigation { get; set; } = null!;
        public virtual Office IdOfficeNavigation { get; set; } = null!;
        public virtual PaymentsClient? PaymentsClient { get; set; }
        public virtual ICollection<ReportClient> ReportClients { get; set; }
    }
}
