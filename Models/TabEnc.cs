using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class TabEnc
    {
        public DateTime Fecha { get; set; }
        public decimal Tasa { get; set; }
        public decimal Tasag10 { get; set; }
        public decimal Tasag20 { get; set; }
        public int TipoImp { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Tasa3 { get; set; }
        public decimal Tasa4 { get; set; }
        public decimal Tasa5 { get; set; }
        public bool Compras { get; set; }
    }
}
