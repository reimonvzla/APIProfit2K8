using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengTax
    {
        public int TaxNum { get; set; }
        public int RengNum { get; set; }
        public string TaxId { get; set; }
        public decimal Tasa1 { get; set; }
        public decimal Tasa2 { get; set; }
        public decimal Tasa3 { get; set; }
        public bool Formula { get; set; }
        public decimal Limite { get; set; }
        public decimal Porc1 { get; set; }
        public decimal Porc2 { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Tax Tax { get; set; }
        public virtual TaxEnc TaxNumNavigation { get; set; }
    }
}
