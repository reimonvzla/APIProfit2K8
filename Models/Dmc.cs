using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Dmc
    {
        public int DmcNum { get; set; }
        public int TipoDmc { get; set; }
        public DateTime FecEmis { get; set; }
        public string CoAgIm { get; set; }
        public string CoAgEx { get; set; }
        public string CoEntA { get; set; }
        public string CoSalD { get; set; }
        public string CoTrans { get; set; }
        public string GuiaEmb { get; set; }
        public int FactNum { get; set; }
        public DateTime FecFact { get; set; }
        public string CoTrasb { get; set; }
        public string RegNum { get; set; }
        public string CoPais { get; set; }
        public string CoPto { get; set; }
        public string CoPaOd { get; set; }
        public string CoPtOd { get; set; }
        public string CoPtTr { get; set; }
        public string CoPtEn { get; set; }
        public string CoPtSa { get; set; }
        public string CoDest { get; set; }
        public string CoDrDe { get; set; }
        public string CoEm { get; set; }
        public string CoDrEm { get; set; }
        public decimal TotFob { get; set; }
        public decimal TotFlet { get; set; }
        public decimal TotSeg { get; set; }
        public decimal TotGast { get; set; }
        public decimal TotCif { get; set; }
        public decimal Itbms { get; set; }
        public decimal DesRec { get; set; }
        public string Status { get; set; }
        public bool Anulada { get; set; }
        public bool Impresa { get; set; }
        public string TipoDoc { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string CoSucu { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public Guid Rowguid { get; set; }
    }
}
