using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class CatArt
    {
        public CatArt()
        {
            Art = new HashSet<Art>();
        }

        public string CoCat { get; set; }
        public string CatDes { get; set; }
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
        public byte[] RowId { get; set; }
        public bool Movil { get; set; }

        public virtual ICollection<Art> Art { get; set; }
    }
}
