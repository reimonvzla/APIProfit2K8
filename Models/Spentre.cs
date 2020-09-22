using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spentre
    {
        public Spentre()
        {
            RengEnt = new HashSet<RengEnt>();
        }

        public int EntNum { get; set; }
        public int OdpNum { get; set; }
        public DateTime FecEmis { get; set; }
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
        public bool Confirma { get; set; }
        public Guid Rowguid { get; set; }
        public string CoSucu { get; set; }
        public int AjuNum { get; set; }
        public string EntDes { get; set; }
        public bool Anulado { get; set; }
        public string CoSub { get; set; }
        public string Comentario { get; set; }
        public DateTime FecConf { get; set; }
        public string DisCen { get; set; }
        public int Numcom { get; set; }
        public DateTime Feccom { get; set; }
        public int Seriales { get; set; }
        public string Trasnfe { get; set; }

        public virtual SubAlma CoSubNavigation { get; set; }
        public virtual Spodp OdpNumNavigation { get; set; }
        public virtual ICollection<RengEnt> RengEnt { get; set; }
    }
}
