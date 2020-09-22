using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIProfit2K8.Models
{
    public partial class ConcAut
    {
        public ConcAut()
        {
            RengCon = new HashSet<RengCon>();
        }

        public string CodCta { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Mes { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ano { get; set; }
        public DateTime FecLoad { get; set; }
        public string Status { get; set; }
        public string Descrip { get; set; }
        public string Archivo { get; set; }
        public Guid Rowguid { get; set; }
        public decimal SaldoEc { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }

        public virtual Cuentas CodCtaNavigation { get; set; }
        public virtual ICollection<RengCon> RengCon { get; set; }
    }
}
