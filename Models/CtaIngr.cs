using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class CtaIngr
    {
        public CtaIngr()
        {
            Clientes = new HashSet<Clientes>();
            DepCaj = new HashSet<DepCaj>();
            MovBan = new HashSet<MovBan>();
            MovCaj = new HashSet<MovCaj>();
            OrdPago = new HashSet<OrdPago>();
            Prov = new HashSet<Prov>();
            RengOpg = new HashSet<RengOpg>();
        }

        public string CoIngr { get; set; }
        public string Descrip { get; set; }
        public string CtaContab { get; set; }
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
        public string CoIslr { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<DepCaj> DepCaj { get; set; }
        public virtual ICollection<MovBan> MovBan { get; set; }
        public virtual ICollection<MovCaj> MovCaj { get; set; }
        public virtual ICollection<OrdPago> OrdPago { get; set; }
        public virtual ICollection<Prov> Prov { get; set; }
        public virtual ICollection<RengOpg> RengOpg { get; set; }
    }
}
