using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class OfficeAd
    {
        public int IdOffice { get; set; }
        public int IdAds { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
        public string Adress { get; set; } = null!;
        public string? AdsCoordinates { get; set; }
        public int IdAdsOffice { get; set; }

        public virtual Ad IdAdsNavigation { get; set; } = null!;
        public virtual Office IdOfficeNavigation { get; set; } = null!;
    }
}
