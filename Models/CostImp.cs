using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class CostImp
    {
        public string CoArt { get; set; }
        public string Nivel { get; set; }
        public decimal Monto { get; set; }
        public int NroDoc { get; set; }
        public int RengDoc { get; set; }
        public string TipoDoc { get; set; }
        public DateTime Fecha { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
