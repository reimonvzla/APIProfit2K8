using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class PagoRengpago
    {
        public int CobNum { get; set; }
        public string Recibo { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public DateTime FecCob { get; set; }
        public decimal Monto { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
        public string CoSucu { get; set; }
        public int RengNum { get; set; }
        public string TipCob { get; set; }
        public decimal MontDoc { get; set; }
    }
}
