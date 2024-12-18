using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class MethodConnection
    {
        public int IdOffice { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Vk { get; set; }
        public string? Instagram { get; set; }
        public string? Facebook { get; set; }

        public virtual Office IdOfficeNavigation { get; set; } = null!;
    }
}
