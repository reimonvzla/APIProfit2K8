using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Sptar
    {
        public Sptar()
        {
            RengAtb = new HashSet<RengAtb>();
            RengMce = new HashSet<RengMce>();
            RengTar = new HashSet<RengTar>();
        }

        public string CoTar { get; set; }
        public string TarDes { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public bool Atributo1 { get; set; }
        public string Vatributo1 { get; set; }
        public bool Atributo2 { get; set; }
        public string Vatributo2 { get; set; }
        public bool Atributo3 { get; set; }
        public string Vatributo3 { get; set; }
        public bool Atributo4 { get; set; }
        public string Vatributo4 { get; set; }
        public bool Atributo5 { get; set; }
        public string Vatributo5 { get; set; }
        public bool Atributo6 { get; set; }
        public string Vatributo6 { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public Guid Rowguid { get; set; }
        public string CoSucu { get; set; }
        public bool? ManMat { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }

        public virtual ICollection<RengAtb> RengAtb { get; set; }
        public virtual ICollection<RengMce> RengMce { get; set; }
        public virtual ICollection<RengTar> RengTar { get; set; }
    }
}
