using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class SubLin
    {
        public SubLin()
        {
            Art = new HashSet<Art>();
        }

        public string CoSubl { get; set; }
        public string SublDes { get; set; }
        public string CoLin { get; set; }
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
        public string CoImun { get; set; }
        public string CoReten { get; set; }
        public string ISublDes { get; set; }
        public bool Movil { get; set; }

        public virtual LinArt CoLinNavigation { get; set; }
        public virtual ICollection<Art> Art { get; set; }
    }
}
