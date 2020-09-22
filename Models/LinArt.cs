using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class LinArt
    {
        public LinArt()
        {
            Art = new HashSet<Art>();
            SubLin = new HashSet<SubLin>();
        }

        public string CoLin { get; set; }
        public string LinDes { get; set; }
        public string DisCen { get; set; }
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
        public decimal ComiLin { get; set; }
        public decimal ComiLin2 { get; set; }
        public byte[] RowId { get; set; }
        public bool Va { get; set; }
        public string ILinDes { get; set; }
        public bool Movil { get; set; }

        public virtual ICollection<Art> Art { get; set; }
        public virtual ICollection<SubLin> SubLin { get; set; }
    }
}
