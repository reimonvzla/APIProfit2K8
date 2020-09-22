using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengEsc
    {
        public int EscNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoArt2 { get; set; }
        public string Descrip { get; set; }
        public string UniVenta { get; set; }
        public double TotalArt { get; set; }
        public decimal CosCalcular { get; set; }
        public decimal CosProUn { get; set; }
        public decimal CosProOm { get; set; }
        public decimal UltCosUn { get; set; }
        public decimal UltCosOm { get; set; }
        public Guid Rowguid { get; set; }
    }
}
