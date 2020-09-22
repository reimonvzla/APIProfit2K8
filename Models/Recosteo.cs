using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Recosteo
    {
        public Guid Rowguid { get; set; }
        public string TipoDoc { get; set; }
        public decimal CosProUn { get; set; }
        public decimal CosProOm { get; set; }
        public decimal UltCosUn { get; set; }
        public decimal UltCosOm { get; set; }
        public int Renglon { get; set; }
        public Guid RowIdDoc { get; set; }
        public int Factura { get; set; }
        public string CoArt { get; set; }
        public decimal? CostUnit { get; set; }
        public decimal? CostUnitOm { get; set; }
        public decimal? Neto { get; set; }
        public decimal? CostoTot { get; set; }
    }
}
