using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Tax
    {
        public Tax()
        {
            RengTax = new HashSet<RengTax>();
        }

        public string TaxId { get; set; }
        public string TaxDes { get; set; }
        public string Entidad { get; set; }
        public decimal Tasa1 { get; set; }
        public decimal Tasa2 { get; set; }
        public decimal Tasa3 { get; set; }
        public bool Formula { get; set; }
        public decimal Limite { get; set; }
        public decimal Porc1 { get; set; }
        public decimal Porc2 { get; set; }
        public string DisCen { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<RengTax> RengTax { get; set; }
    }
}
