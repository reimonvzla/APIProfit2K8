using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengExp2
    {
        public int ExpNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoArt2 { get; set; }
        public string Descrip { get; set; }
        public string UniVenta { get; set; }
        public double Existencia { get; set; }
        public double TotalArt { get; set; }
        public double Faltante { get; set; }
        public double Costo { get; set; }
        public double CostoPro { get; set; }
        public double Porllegar { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spexplosion ExpNumNavigation { get; set; }
    }
}
