using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spexplosion
    {
        public Spexplosion()
        {
            RengExp = new HashSet<RengExp>();
            RengExp2 = new HashSet<RengExp2>();
        }

        public int ExpNum { get; set; }
        public DateTime Fecha { get; set; }
        public string AlmOrig { get; set; }
        public string MotivoGlo { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Expnfe { get; set; }
        public string CoSucu { get; set; }
        public string Comentario { get; set; }
        public Guid Rowguid { get; set; }
        public string Trasnfe { get; set; }
        public string CoAlma { get; set; }

        public virtual ICollection<RengExp> RengExp { get; set; }
        public virtual ICollection<RengExp2> RengExp2 { get; set; }
    }
}
