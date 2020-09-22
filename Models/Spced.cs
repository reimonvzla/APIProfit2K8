using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spced
    {
        public Spced()
        {
            RengAce = new HashSet<RengAce>();
            RengAtc = new HashSet<RengAtc>();
            RengEce = new HashSet<RengEce>();
            RengGce = new HashSet<RengGce>();
            RengMce = new HashSet<RengMce>();
            Spodp = new HashSet<Spodp>();
        }

        public int CoCed { get; set; }
        public string CedDes { get; set; }
        public decimal CapMax { get; set; }
        public bool Estandar { get; set; }
        public DateTime FecEmis { get; set; }
        public string CoArt { get; set; }
        public decimal Cantidad { get; set; }
        public string CoUni { get; set; }
        public string CoDep { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public Guid Rowguid { get; set; }
        public string CoSucu { get; set; }
        public string DisCen { get; set; }
        public int Numcom { get; set; }
        public DateTime Feccom { get; set; }
        public int Dias { get; set; }
        public decimal Horas { get; set; }
        public decimal PorCos { get; set; }
        public string Trasnfe { get; set; }
        public decimal TotalUni { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual ICollection<RengAce> RengAce { get; set; }
        public virtual ICollection<RengAtc> RengAtc { get; set; }
        public virtual ICollection<RengEce> RengEce { get; set; }
        public virtual ICollection<RengGce> RengGce { get; set; }
        public virtual ICollection<RengMce> RengMce { get; set; }
        public virtual ICollection<Spodp> Spodp { get; set; }
    }
}
