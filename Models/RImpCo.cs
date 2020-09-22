using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RImpCo
    {
        public int FactNu1 { get; set; }
        public int RengNu1 { get; set; }
        public int FactNu2 { get; set; }
        public int RengNu2 { get; set; }
        public decimal Monto { get; set; }
        public Guid Rowguid { get; set; }

        public virtual RengAco RengAco { get; set; }
        public virtual RengAim RengAim { get; set; }
    }
}
