using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class TipoPro
    {
        public TipoPro()
        {
            Prov = new HashSet<Prov>();
        }

        public string TipPro { get; set; }
        public string DesTipo { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<Prov> Prov { get; set; }
    }
}
