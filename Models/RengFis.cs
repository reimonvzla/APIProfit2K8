using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengFis
    {
        public int NumFis { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoLin { get; set; }
        public string CoAlma { get; set; }
        public decimal StockTeor { get; set; }
        public decimal StockReal { get; set; }
        public decimal SstockTeo { get; set; }
        public decimal StotalArt { get; set; }
        public decimal CostoUni { get; set; }
        public string AjuNum { get; set; }
        public int SajuNum { get; set; }
        public bool Cerrado { get; set; }
        public string UniVenta { get; set; }
        public string SuniVenta { get; set; }
        public int TCosto { get; set; }
        public Guid Rowguid { get; set; }
        public decimal TotalUni { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public decimal CostoUniOm { get; set; }
        public decimal Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
