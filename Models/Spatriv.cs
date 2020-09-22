using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spatriv
    {
        public Spatriv()
        {
            RengAtb = new HashSet<RengAtb>();
            RengAtc = new HashSet<RengAtc>();
        }

        public string CoAtriv { get; set; }
        public string AtrivDes { get; set; }
        public int Tipo { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public Guid Rowguid { get; set; }
        public string Revisado { get; set; }
        public string CoSucu { get; set; }
        public string Trasnfe { get; set; }

        public virtual ICollection<RengAtb> RengAtb { get; set; }
        public virtual ICollection<RengAtc> RengAtc { get; set; }
    }
}
