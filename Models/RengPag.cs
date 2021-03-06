﻿using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengPag
    {
        public int CobNum { get; set; }
        public int RengNum { get; set; }
        public string TpDocCob { get; set; }
        public int DocNum { get; set; }
        public decimal Neto { get; set; }
        public decimal NetoTmp { get; set; }
        public decimal Dppago { get; set; }
        public decimal DppagoTmp { get; set; }
        public decimal RengNcr { get; set; }
        public string CoVen { get; set; }
        public decimal ComiPorc { get; set; }
        public decimal ComiLinea { get; set; }
        public decimal ComiConc { get; set; }
        public decimal ComiArt { get; set; }
        public string SignAjuC { get; set; }
        public decimal PorcAjuC { get; set; }
        public decimal PorCob { get; set; }
        public decimal ComiCob { get; set; }
        public decimal MontCob { get; set; }
        public bool SinoPago { get; set; }
        public bool SinoReten { get; set; }
        public decimal MontoReten { get; set; }
        public decimal MontoDppago { get; set; }
        public decimal ImpPago { get; set; }
        public decimal MontoObj { get; set; }
        public decimal Isv { get; set; }
        public string NroFact { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
        public decimal Sustraen { get; set; }
        public Guid Rowguid { get; set; }
        public string CoIslr { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public decimal RetIva { get; set; }
        public int FactIva { get; set; }
        public string Numcon { get; set; }
        public decimal PorcRetn { get; set; }
        public decimal PorcDesc { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string ProvTer { get; set; }
        public int RengTer { get; set; }
        public DateTime? FecCom { get; set; }
    }
}
