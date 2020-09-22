using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class ArtExt
    {
        public string CoArt { get; set; }
        public decimal PorcMax { get; set; }
        public bool PPrecMax { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
