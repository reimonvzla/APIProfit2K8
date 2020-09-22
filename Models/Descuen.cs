using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Descuen
    {
        public string CoDesc { get; set; }
        public string TipoCli { get; set; }
        public string TipoDesc { get; set; }
        public decimal Hasta1 { get; set; }
        public decimal Hasta2 { get; set; }
        public decimal Hasta3 { get; set; }
        public decimal Hasta4 { get; set; }
        public decimal Hasta5 { get; set; }
        public decimal Porc1 { get; set; }
        public decimal Porc2 { get; set; }
        public decimal Porc3 { get; set; }
        public decimal Porc4 { get; set; }
        public decimal Porc5 { get; set; }
        public decimal Porc6 { get; set; }
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
        public byte[] RowId { get; set; }
    }
}
