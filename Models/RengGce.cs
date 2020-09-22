using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengGce
    {
        public int CoCed { get; set; }
        public int RengNum { get; set; }
        public string CoGas { get; set; }
        public decimal Cantidad { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spced CoCedNavigation { get; set; }
        public virtual Spgasfab CoGasNavigation { get; set; }
    }
}
