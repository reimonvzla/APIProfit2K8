using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengNdr
    {
        public int FactNum { get; set; }
        public int RengNum { get; set; }
        public string DisCen { get; set; }
        public string TipoDoc { get; set; }
        public int RengDoc { get; set; }
        public int NumDoc { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public decimal Pendiente { get; set; }
        public string UniVenta { get; set; }
        public decimal PrecVta { get; set; }
        public string PorcDesc { get; set; }
        public string TipoImp { get; set; }
        public decimal? RengNeto { get; set; }
        public decimal CosProUn { get; set; }
        public decimal UltCosUn { get; set; }
        public decimal UltCosOm { get; set; }
        public decimal CosProOm { get; set; }
        public decimal TotalDev { get; set; }
        public decimal MontoDev { get; set; }
        public decimal PrecVta2 { get; set; }
        public bool Anulado { get; set; }
        public string DesArt { get; set; }
        public bool Seleccion { get; set; }
        public decimal CantImp { get; set; }
        public string Comentario { get; set; }
        public Guid Rowguid { get; set; }
        public decimal TotalUni { get; set; }
        public decimal MonIlc { get; set; }
        public decimal Otros { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public decimal Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public string CoAlma2 { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public decimal CantProd { get; set; }
        public decimal ImpProd { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
        public virtual Art CoArtNavigation { get; set; }
    }
}
