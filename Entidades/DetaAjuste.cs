namespace APIProfit2K8.Entidades
{
    using System;
    public class DetaAjuste
    {
        public int AjueNum { get; set; }
        public int RengNum { get; set; }
        public string DisCen { get; set; }
        public string Tipo { get; set; }
        public string CoArt { get; set; }
        public decimal TotalArt { get; set; }
        public string UniCompra { get; set; }
        public decimal StotalArt { get; set; }
        public string SuniCompr { get; set; }
        public string CoAlma { get; set; }
        public decimal CostUnitOm { get; set; }
        public decimal CostUnit { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public string UniVenta { get; set; }
        public string SuniVenta { get; set; }
        public decimal CosProUn { get; set; }
        public decimal UltCosOm { get; set; }
        public decimal CosProOm { get; set; }
        public Guid Rowguid { get; set; }
        public decimal TotalUni { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public decimal Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public decimal MoCant { get; set; }
        public decimal GfCant { get; set; }
        public decimal MoCantOm { get; set; }
        public decimal GfCantOm { get; set; }
        public bool Produccion { get; set; }

        public virtual EncabAjuste EncabAjuste { get; set; }
    }
}
