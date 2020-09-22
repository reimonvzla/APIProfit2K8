using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class ImpMun
    {
        public string CoImp { get; set; }
        public string ImpDes { get; set; }
        public decimal Alicuota { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
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
        public string CoAlma { get; set; }
        public string NAct { get; set; }
        public decimal MTrib { get; set; }

        public virtual Almacen CoAlmaNavigation { get; set; }
    }
}
