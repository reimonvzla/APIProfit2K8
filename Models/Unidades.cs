using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Unidades
    {
        public Unidades()
        {
            ArtSuniVentaNavigation = new HashSet<Art>();
            ArtUniVentaNavigation = new HashSet<Art>();
            RengEmb = new HashSet<RengEmb>();
        }

        public string CoUni { get; set; }
        public string DesUni { get; set; }
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
        public byte[] RowId { get; set; }

        public virtual ICollection<Art> ArtSuniVentaNavigation { get; set; }
        public virtual ICollection<Art> ArtUniVentaNavigation { get; set; }
        public virtual ICollection<RengEmb> RengEmb { get; set; }
    }
}
