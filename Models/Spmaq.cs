using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spmaq
    {
        public Spmaq()
        {
            RengTar = new HashSet<RengTar>();
            Spparmaq = new HashSet<Spparmaq>();
        }

        public string CoMaq { get; set; }
        public string MaqDes { get; set; }
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
        public string CoSucu { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }

        public virtual ICollection<RengTar> RengTar { get; set; }
        public virtual ICollection<Spparmaq> Spparmaq { get; set; }
    }
}
