using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class FactDevo
    {
        public string TipoDoc { get; set; }
        public int FactNum { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public string CoSucu { get; set; }
        public string Status { get; set; }
        public decimal? TotNeto { get; set; }
        public decimal TotNeto2 { get; set; }
        public decimal? TotBruto { get; set; }
        public decimal TotBruto2 { get; set; }
        public decimal? Iva { get; set; }
        public decimal Iva2 { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public decimal? TotalArt { get; set; }
        public decimal Pendiente { get; set; }
        public string UniVenta { get; set; }
        public decimal PrecVta { get; set; }
        public string PorcDesc { get; set; }
        public string TipoImp { get; set; }
        public decimal RengNeto2 { get; set; }
        public decimal? CosProUn { get; set; }
        public decimal? UltCosUn { get; set; }
        public decimal? UltCosOm { get; set; }
        public decimal? CosProOm { get; set; }
        public decimal TotalDev { get; set; }
        public decimal MontoDev { get; set; }
        public decimal? Procesado { get; set; }
        public decimal? Tasag { get; set; }
        public decimal IvaRengFac { get; set; }
        public decimal RengNetoFac { get; set; }
        public decimal? IvaRengDev { get; set; }
        public decimal? RengNetoDev { get; set; }
        public decimal? NetoFact { get; set; }
        public decimal? IvaFact { get; set; }
        public decimal NetoDev { get; set; }
        public decimal IvaDev { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
        public bool PMargCap { get; set; }
        public decimal? TotNetoOm { get; set; }
        public decimal? TotNeto2Om { get; set; }
        public decimal? TotBrutoOm { get; set; }
        public decimal? TotBruto2Om { get; set; }
        public decimal? IvaOm { get; set; }
        public decimal? Iva2Om { get; set; }
        public decimal? RengNeto2Om { get; set; }
        public decimal? MontoDevOm { get; set; }
        public decimal? ProcesadoOm { get; set; }
        public decimal? IvaRengFacOm { get; set; }
        public decimal? RengNetoFacOm { get; set; }
        public decimal? IvaRengDevOm { get; set; }
        public decimal? RengNetoDevOm { get; set; }
        public decimal? NetoFactOm { get; set; }
        public decimal? IvaFactOm { get; set; }
        public decimal? NetoDevOm { get; set; }
        public decimal? IvaDevOm { get; set; }
    }
}
