using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Client
    {
        public Client()
        {
            Feedbacks = new HashSet<Feedback>();
            OrderClients = new HashSet<OrderClient>();
        }

        public int IdClients { get; set; }
        public string Fio { get; set; } = null!;
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public bool? Blocked { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
        public virtual ICollection<OrderClient> OrderClients { get; set; }
    }
}
