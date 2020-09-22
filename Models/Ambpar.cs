using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Ambpar
    {
        public string AmbUsua { get; set; }
        public bool? FallaNum { get; set; }
        public bool? FallaFut { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public Guid Rowguid { get; set; }
        public string Trasnfe { get; set; }
    }
}
