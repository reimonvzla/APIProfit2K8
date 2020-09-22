using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengImp
    {
        public int InpNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoArt2 { get; set; }
        public string Descrip { get; set; }
        public string UniVenta { get; set; }
        public decimal Existencia { get; set; }
        public decimal TotalArt { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spimplosion InpNumNavigation { get; set; }
    }
}
