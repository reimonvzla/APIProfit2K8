using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengEnt
    {
        public int EntNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public decimal TotalArt { get; set; }
        public string CoUni { get; set; }
        public string NroLote { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime FecLote { get; set; }
        public decimal StotalArt { get; set; }
        public string DisCen { get; set; }
        public int Numcom { get; set; }
        public DateTime Feccom { get; set; }
        public decimal TotalUni { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual Spentre EntNumNavigation { get; set; }
    }
}
