using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengDcc
    {
        public string TipoDoc { get; set; }
        public int NroDoc { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public decimal TotalArt { get; set; }
        public decimal PrecVta { get; set; }
        public decimal PrecVta2 { get; set; }
        public decimal? RengNeto { get; set; }
        public string TipoImp { get; set; }
        public Guid Rowguid { get; set; }
        public string DisCen { get; set; }
        public string UniVenta { get; set; }
        public decimal TotalUni { get; set; }
        public string DesArt { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
