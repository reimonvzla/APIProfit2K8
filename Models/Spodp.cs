using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spodp
    {
        public Spodp()
        {
            RengOdp = new HashSet<RengOdp>();
            Spcierre = new HashSet<Spcierre>();
            Spentre = new HashSet<Spentre>();
        }

        public int OdpNum { get; set; }
        public string CoArt { get; set; }
        public int CoCed { get; set; }
        public decimal CaArt { get; set; }
        public DateTime FeInic { get; set; }
        public DateTime FeFin { get; set; }
        public int Prioridad { get; set; }
        public string EdoOdp { get; set; }
        public int NumMaqblo { get; set; }
        public decimal CtEstim { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime FeEmis { get; set; }
        public string Descrip { get; set; }
        public string Comentario { get; set; }
        public string CoSucu { get; set; }
        public bool Anulado { get; set; }
        public string DisCen { get; set; }
        public decimal MpCant { get; set; }
        public decimal MoCant { get; set; }
        public decimal GfCant { get; set; }
        public decimal MenCant { get; set; }
        public decimal MemCant { get; set; }
        public decimal OiCant { get; set; }
        public string Trasnfe { get; set; }
        public decimal TotalUni { get; set; }
        public string UniVenta { get; set; }
        public int Codpcom { get; set; }
        public int Nodpcom { get; set; }
        public int DocOri { get; set; }

        public virtual Spced CoCedNavigation { get; set; }
        public virtual ICollection<RengOdp> RengOdp { get; set; }
        public virtual ICollection<Spcierre> Spcierre { get; set; }
        public virtual ICollection<Spentre> Spentre { get; set; }
    }
}
