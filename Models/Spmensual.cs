using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spmensual
    {
        public string CoArt { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Diasinv { get; set; }
        public int Diasprod { get; set; }
        public int Holgura { get; set; }
        public string Periodo { get; set; }
        public decimal Cantprod { get; set; }
        public string Trasnfe { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public string CoSucu { get; set; }
        public int CodCed { get; set; }
        public decimal Pendpro { get; set; }
        public decimal Mesprox { get; set; }
        public decimal Stockop { get; set; }
        public decimal Stockact { get; set; }
    }
}
