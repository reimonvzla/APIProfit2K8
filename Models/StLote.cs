using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class StLote
    {
        public string CoAlma { get; set; }
        public string CoArt { get; set; }
        public string NroLote { get; set; }
        public decimal StockAct { get; set; }
        public decimal SstockAct { get; set; }
        public decimal StockCom { get; set; }
        public decimal SstockCom { get; set; }
        public decimal StockLle { get; set; }
        public decimal SstockLle { get; set; }
        public decimal StockDes { get; set; }
        public decimal SstockDes { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
        public virtual Art CoArtNavigation { get; set; }
        public virtual Lote Lote { get; set; }
    }
}
