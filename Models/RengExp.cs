using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengExp
    {
        public int ExpNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string UniVenta { get; set; }
        public string SuniVenta { get; set; }
        public double TotalUni { get; set; }
        public string Descrip { get; set; }
        public double TotalArt { get; set; }
        public double StotalArt { get; set; }
        public double CosProUn { get; set; }
        public double CosProOm { get; set; }
        public double UltCosUn { get; set; }
        public double UltCosOm { get; set; }
        public double Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public int CantSol { get; set; }
        public Guid Rowguid { get; set; }
        public int CodCed { get; set; }

        public virtual Spexplosion RengNumNavigation { get; set; }
    }
}
