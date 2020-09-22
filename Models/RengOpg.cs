using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengOpg
    {
        public int OrdNum { get; set; }
        public int RengNum { get; set; }
        public string CtaEgre { get; set; }
        public string Descrip { get; set; }
        public decimal MontoA { get; set; }
        public decimal MontoCo { get; set; }
        public Guid Rowguid { get; set; }
        public string DisCen { get; set; }
        public string TipoImp { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual CtaIngr CtaEgreNavigation { get; set; }
    }
}
