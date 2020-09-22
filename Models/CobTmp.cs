using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class CobTmp
    {
        public int CobNum { get; set; }
        public int RengNum { get; set; }
        public string TipCob { get; set; }
        public string NumDoc { get; set; }
        public string MontDoc { get; set; }
        public string Banco { get; set; }
        public string CodCaja { get; set; }
        public string DesCaja { get; set; }
        public string FecCheq { get; set; }
        public string NombreBan { get; set; }
        public string Numero { get; set; }
        public string SinoPago { get; set; }
        public string SinoReten { get; set; }
        public string MontoDppa { get; set; }
        public string MontoRete { get; set; }
        public string MontCobro { get; set; }
        public string Saldo { get; set; }
        public string Neto { get; set; }
        public double Giro { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public DateTime FechaVen { get; set; }
    }
}
