using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class GeneKit
    {
        public int GeneNum { get; set; }
        public DateTime Fecha { get; set; }
        public string CoArt { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
        public string DisCen { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public decimal CostoTot { get; set; }
        public string CoAlma { get; set; }
        public int AjuEnt { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Pendiente2 { get; set; }
        public decimal TotalUni { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
        public virtual Art CoArtNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
    }
}
