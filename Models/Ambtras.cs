using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Ambtras
    {
        public string AmbUsua { get; set; }
        public bool? TrasNum { get; set; }
        public bool? Almaori { get; set; }
        public bool Almorid { get; set; }
        public string AlmaOri1 { get; set; }
        public bool? Almades { get; set; }
        public bool Almdesd { get; set; }
        public string AlmaDes1 { get; set; }
        public bool? Fecha { get; set; }
        public bool? Motivo { get; set; }
        public bool? BtSer { get; set; }
        public bool? BtAnula { get; set; }
        public bool? BtReversa { get; set; }
        public bool? Confirma { get; set; }
        public bool? Desconfima { get; set; }
        public bool? StockNeg { get; set; }
        public bool? PstockNeg { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }
        public bool PLotefec { get; set; }

        public virtual Almacen CoSucuNavigation { get; set; }
    }
}
