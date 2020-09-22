using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Import
    {
        public Import()
        {
            ExpImp = new HashSet<ExpImp>();
            RengAco = new HashSet<RengAco>();
            RengAim = new HashSet<RengAim>();
        }

        public int ImpNum { get; set; }
        public string Status { get; set; }
        public DateTime FecImp { get; set; }
        public string Descrip { get; set; }
        public string CoMone { get; set; }
        public string CoSucu { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public int AjusNum { get; set; }
        public string NCostB { get; set; }
        public Guid Rowguid { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public decimal Tasa { get; set; }
        public int DGasto { get; set; }

        public virtual Moneda CoMoneNavigation { get; set; }
        public virtual ICollection<ExpImp> ExpImp { get; set; }
        public virtual ICollection<RengAco> RengAco { get; set; }
        public virtual ICollection<RengAim> RengAim { get; set; }
    }
}
