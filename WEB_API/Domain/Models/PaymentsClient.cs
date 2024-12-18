using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class PaymentsClient
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public double Price { get; set; }
        public string Description { get; set; } = null!;
        public int IdOrderClients { get; set; }
        public int IdClients { get; set; }

        public virtual OrderClient IdOrderClientsNavigation { get; set; } = null!;
    }
}
