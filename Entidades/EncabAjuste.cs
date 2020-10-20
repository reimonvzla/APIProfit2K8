namespace APIProfit2K8.Entidades
{
    using System;
    using System.Collections.Generic;

    public class EncabAjuste
    {
        public int AjueNum { get; set; }
        public DateTime Fecha { get; set; }
        public string Motivo { get; set; }
        public decimal Total { get; set; }
        public int Seriales { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
        public string DisCen { get; set; }
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
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }
        public bool Anulada { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public bool Produccion { get; set; }
        public int ImpNum { get; set; }
        public int FactNum { get; set; }

        public ICollection<DetaAjuste> DetaAjuste { get; set; }
    }
}
