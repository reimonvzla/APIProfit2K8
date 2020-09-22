using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spparmaq
    {
        public int ParNum { get; set; }
        public string ParDes { get; set; }
        public DateTime FecInic { get; set; }
        public DateTime FecFin { get; set; }
        public string CoMaq { get; set; }
        public string CoFalla { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime FecEmis { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }

        public virtual Spfalla CoFallaNavigation { get; set; }
        public virtual Spmaq CoMaqNavigation { get; set; }
    }
}
