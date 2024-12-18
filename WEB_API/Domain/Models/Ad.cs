using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public partial class Ad
    {
        public Ad()
        {
            OfficeAds = new HashSet<OfficeAd>();
        }

        public int IdAds { get; set; }
        public string TypeAds { get; set; } = null!;
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<OfficeAd> OfficeAds { get; set; }
    }
}
