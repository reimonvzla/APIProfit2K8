using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengMce
    {
        public int CoCed { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoTar { get; set; }
        public decimal Cantidad { get; set; }
        public string CoUni { get; set; }
        public Guid Rowguid { get; set; }
        public decimal StotalArt { get; set; }
        public string DisCen { get; set; }
        public decimal CantMax { get; set; }
        public int Numcom { get; set; }
        public DateTime Feccom { get; set; }
        public decimal TotalUni { get; set; }

        public virtual Spced CoCedNavigation { get; set; }
        public virtual Sptar CoTarNavigation { get; set; }
    }
}
