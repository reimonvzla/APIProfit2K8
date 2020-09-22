using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Ambcierre
    {
        public string AmbUsua { get; set; }
        public bool EntNum { get; set; }
        public bool Almacen { get; set; }
        public bool Almacend { get; set; }
        public string CoAlma { get; set; }
        public bool BtSerial { get; set; }
        public bool BtAnulo { get; set; }
        public bool BtReversa { get; set; }
        public bool Fecha { get; set; }
        public bool BtConfirm { get; set; }
        public bool OdpNum { get; set; }
        public bool EntDes { get; set; }
        public bool BtDecon { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public string CoUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsIn { get; set; }
        public DateTime FeUsMo { get; set; }
        public DateTime FeUsEl { get; set; }
        public Guid Rowguid { get; set; }
        public string Trasnfe { get; set; }
    }
}
