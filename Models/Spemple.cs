using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spemple
    {
        public Spemple()
        {
            RengEce = new HashSet<RengEce>();
        }

        public string CoEmp { get; set; }
        public string Nombres { get; set; }
        public decimal SueldoBas { get; set; }
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

        public virtual ICollection<RengEce> RengEce { get; set; }
    }
}
