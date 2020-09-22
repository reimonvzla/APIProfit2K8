using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Chequeras
    {
        public Chequeras()
        {
            Cheques = new HashSet<Cheques>();
        }

        public string CoChra { get; set; }
        public string ChraDes { get; set; }
        public string CodCta { get; set; }
        public DateTime FechaRe { get; set; }
        public int NumChP { get; set; }
        public int NumChU { get; set; }
        public string Respons { get; set; }
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
        public string Status { get; set; }
        public bool LimUsoRe { get; set; }
        public bool ChGen { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Cuentas CodCtaNavigation { get; set; }
        public virtual ICollection<Cheques> Cheques { get; set; }
    }
}
