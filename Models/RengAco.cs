using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengAco
    {
        public RengAco()
        {
            RImpCo = new HashSet<RImpCo>();
        }

        public int ImpNum { get; set; }
        public int RengNum { get; set; }
        public int FactNum { get; set; }
        public string CoArt { get; set; }
        public decimal Monto { get; set; }
        public decimal MontoAp { get; set; }
        public string NCosto { get; set; }
        public Guid Rowguid { get; set; }
        public string TipoDoc { get; set; }
        public int TipoDis { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
        public int RengDoc { get; set; }
        public int FacGast { get; set; }
        public int ArtGast { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual Import ImpNumNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
        public virtual ICollection<RImpCo> RImpCo { get; set; }
    }
}
