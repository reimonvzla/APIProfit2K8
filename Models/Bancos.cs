using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Bancos
    {
        public Bancos()
        {
            Cuentas = new HashSet<Cuentas>();
            ParConc = new HashSet<ParConc>();
        }

        public string CoBan { get; set; }
        public string DesBan { get; set; }
        public string Telefonos { get; set; }
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
        public decimal Plazo1 { get; set; }
        public decimal Plazo2 { get; set; }
        public decimal Plazo3 { get; set; }
        public decimal Plazo4 { get; set; }
        public byte[] RowId { get; set; }

        public virtual ICollection<Cuentas> Cuentas { get; set; }
        public virtual ICollection<ParConc> ParConc { get; set; }
    }
}
