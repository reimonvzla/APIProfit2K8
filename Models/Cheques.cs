using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Cheques
    {
        public string CoCheq { get; set; }
        public string CoChra { get; set; }
        public string Status { get; set; }
        public decimal Monto { get; set; }
        public string Descrip { get; set; }
        public DateTime? FecEmis { get; set; }
        public DateTime? FecEnt { get; set; }
        public string EntregA { get; set; }
        public string Coment { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public int MovNum { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Chequeras CoChraNavigation { get; set; }
    }
}
