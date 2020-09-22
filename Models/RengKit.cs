using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengKit
    {
        public int KitNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public DateTime FecEmis { get; set; }
        public string DesKit { get; set; }
        public string UniVenta { get; set; }
        public decimal TotalArt { get; set; }
        public Guid Rowguid { get; set; }
        public decimal TotalUni { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public decimal Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
