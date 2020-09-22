using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengFci
    {
        public int ImpNum { get; set; }
        public int RengNum { get; set; }
        public int FactNum { get; set; }
        public double TotNeto { get; set; }
        public string Descrip { get; set; }
        public double MontoDis { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
    }
}
