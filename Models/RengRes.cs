using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengRes
    {
        public int RmaNum { get; set; }
        public int RengNum { get; set; }
        public string Tipo { get; set; }
        public string CoArt { get; set; }
        public double TotalArt { get; set; }
        public double StotalArt { get; set; }
        public string CoAlma { get; set; }
        public string Unidad { get; set; }
        public string DesArt { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
        public virtual Art CoArtNavigation { get; set; }
        public virtual RmaRes RmaNumNavigation { get; set; }
    }
}
