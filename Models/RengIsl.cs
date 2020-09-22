using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengIsl
    {
        public string TipoDoc { get; set; }
        public int DocNum { get; set; }
        public int RengNum { get; set; }
        public int FactNum { get; set; }
        public string CoIslr { get; set; }
        public decimal MontoObj { get; set; }
        public decimal MontoReten { get; set; }
        public decimal Sustraen { get; set; }
        public decimal PorcRetn { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ConIslr CoIslrNavigation { get; set; }
    }
}
