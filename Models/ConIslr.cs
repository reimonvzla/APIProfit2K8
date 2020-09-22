using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class ConIslr
    {
        public ConIslr()
        {
            RengIsl = new HashSet<RengIsl>();
            RengTab = new HashSet<RengTab>();
        }

        public string CoIslr { get; set; }
        public string IslrDes { get; set; }
        public string IslrDes2 { get; set; }
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
        public string Numeral { get; set; }
        public string Literal { get; set; }

        public virtual ICollection<RengIsl> RengIsl { get; set; }
        public virtual ICollection<RengTab> RengTab { get; set; }
    }
}
