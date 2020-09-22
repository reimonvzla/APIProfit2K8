using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Importac
    {
        public int ImpNum { get; set; }
        public int NumPlvc { get; set; }
        public double TotPlvc { get; set; }
        public string Descrip { get; set; }
        public DateTime FecEmis { get; set; }
        public double OtroCos { get; set; }
        public double TotFai { get; set; }
        public double TotFci { get; set; }
        public int TipoDis { get; set; }
        public bool Anulada { get; set; }
        public bool Impresa { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
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
        public decimal MontoBase { get; set; }
        public decimal Iva { get; set; }
        public string Planilla { get; set; }
        public string Comentario { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
    }
}
