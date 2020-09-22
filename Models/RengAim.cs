using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengAim
    {
        public RengAim()
        {
            RImpCo = new HashSet<RImpCo>();
        }

        public int ImpNum { get; set; }
        public int RengNum { get; set; }
        public int FactNum { get; set; }
        public string CoArt { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Neto { get; set; }
        public Guid Rowguid { get; set; }
        public decimal CostoD { get; set; }
        public decimal NuevoCo { get; set; }
        public decimal Margen { get; set; }
        public decimal PorcAra { get; set; }
        public decimal PieCub { get; set; }
        public decimal Peso { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
        public int RengDoc { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual Import ImpNumNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
        public virtual RengCom RengCom { get; set; }
        public virtual ICollection<RImpCo> RImpCo { get; set; }
    }
}
