﻿using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Partner
    {
        public Partner()
        {
            OfficePartners = new HashSet<OfficePartner>();
        }

        public int IdPartners { get; set; }
        public string NameCompany { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public string? CompanyActivity { get; set; }

        public virtual ICollection<OfficePartner> OfficePartners { get; set; }
    }
}
