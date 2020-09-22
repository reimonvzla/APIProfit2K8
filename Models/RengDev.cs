using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengDev
    {
        public int DevNum { get; set; }
        public int RengNum { get; set; }
        public string DisCen { get; set; }
        public string CoArt { get; set; }
        public decimal CantEnt { get; set; }
        public decimal CantCom { get; set; }
        public decimal CantXdev { get; set; }
        public decimal CantDev { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public string Descrip { get; set; }
        public string UniVenta { get; set; }
        public string SuniVenta { get; set; }
        public decimal TotalUni { get; set; }
        public decimal CosProUn { get; set; }
        public decimal CosProOm { get; set; }
        public decimal UltCosUn { get; set; }
        public decimal UltCosOm { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public decimal Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public string Multilote { get; set; }
        public int Subced { get; set; }
        public decimal TotalArt2 { get; set; }
        public Guid Rowguid { get; set; }
        public string CoTar { get; set; }
    }
}
