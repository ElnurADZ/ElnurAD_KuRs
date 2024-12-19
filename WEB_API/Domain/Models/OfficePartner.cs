using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OfficePartner
    {
        public int IdOffice { get; set; }
        public int IdPartners { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual Office IdOfficeNavigation { get; set; } = null!;
        public virtual Partner IdPartnersNavigation { get; set; } = null!;
    }
}
