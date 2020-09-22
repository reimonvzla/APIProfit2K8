using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class DepCaj
    {
        public int DepNum { get; set; }
        public string Deposito { get; set; }
        public DateTime Fecha { get; set; }
        public int Movi { get; set; }
        public string CodCta { get; set; }
        public string CodCaja { get; set; }
        public int Movie { get; set; }
        public decimal TotalEfec { get; set; }
        public decimal TotalCheq { get; set; }
        public decimal TotalTarj { get; set; }
        public int CheDev { get; set; }
        public string CtaEgre { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public string CtaCont01 { get; set; }
        public string CtaCont02 { get; set; }
        public string CtaCont03 { get; set; }
        public string DisCen { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
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
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Almacen CoSucuNavigation { get; set; }
        public virtual Cuentas CodCtaNavigation { get; set; }
        public virtual CtaIngr CtaEgreNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
    }
}
