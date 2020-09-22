using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Cobpvta
    {
        public int FactNum { get; set; }
        public int NumTurno { get; set; }
        public double Efec1 { get; set; }
        public double Cheq1 { get; set; }
        public double Cheq2 { get; set; }
        public double Tarj1 { get; set; }
        public double Tarj2 { get; set; }
        public string DocNum1 { get; set; }
        public string DocNum2 { get; set; }
        public string DocNum3 { get; set; }
        public string DocNum4 { get; set; }
        public string BancTarj1 { get; set; }
        public string BancTarj2 { get; set; }
        public string BancTarj3 { get; set; }
        public string BancTarj4 { get; set; }
        public DateTime FechaChe1 { get; set; }
        public DateTime FechaChe2 { get; set; }
        public DateTime FechaChe3 { get; set; }
        public DateTime FechaChe4 { get; set; }
        public string Op1 { get; set; }
        public string Op2 { get; set; }
        public string Op3 { get; set; }
        public string Op4 { get; set; }
        public string Clave1 { get; set; }
        public string Clave2 { get; set; }
        public string Clave3 { get; set; }
        public string Clave4 { get; set; }
        public string Cobrador { get; set; }
        public string Moneda { get; set; }
        public double Tasa { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public double Total { get; set; }
        public double Vuelto { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
    }
}
