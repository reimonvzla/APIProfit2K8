using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengAce
    {
        public int CoCed { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public decimal Cant { get; set; }
        public string CoUni { get; set; }
        public Guid Rowguid { get; set; }
        public string DisCen { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public decimal PorCos { get; set; }
        public int Subced { get; set; }
        public decimal TotalUni { get; set; }
        public decimal CantProd { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual Spced CoCedNavigation { get; set; }
    }
}
