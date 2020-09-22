using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengMen
    {
        public int MenNum { get; set; }
        public int RengNum { get; set; }
        public int OdpNum { get; set; }
        public string CoArt { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Pendpro { get; set; }
        public decimal Stockop { get; set; }
        public decimal Stockact { get; set; }
        public decimal Diasinv { get; set; }
        public int Diasprod { get; set; }
        public int Holgura { get; set; }
        public decimal Cantprod { get; set; }
        public string Periodo { get; set; }
        public int CodCed { get; set; }
        public decimal Mesprox { get; set; }
        public decimal Comprom { get; set; }
        public bool Producir { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spmenenc MenNumNavigation { get; set; }
    }
}
