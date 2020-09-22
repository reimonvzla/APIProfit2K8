using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Tasas
    {
        public string CoMone { get; set; }
        public DateTime Fecha { get; set; }
        public decimal TasaC { get; set; }
        public decimal TasaV { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Moneda CoMoneNavigation { get; set; }
    }
}
