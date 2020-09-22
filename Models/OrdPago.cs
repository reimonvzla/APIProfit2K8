using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class OrdPago
    {
        public int OrdNum { get; set; }
        public string Status { get; set; }
        public DateTime Fecha { get; set; }
        public string CodBen { get; set; }
        public string Descrip { get; set; }
        public string FormaPag { get; set; }
        public decimal Monto { get; set; }
        public string TipoImp { get; set; }
        public DateTime FecPag { get; set; }
        public string CodCta { get; set; }
        public string Cheque { get; set; }
        public string CodCaja { get; set; }
        public int MovNum { get; set; }
        public string CtaEgre { get; set; }
        public DateTime Feccom { get; set; }
        public string DisCen { get; set; }
        public int Numcom { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
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
        public int MovIslr { get; set; }
        public bool SinoReten { get; set; }
        public bool RengSi { get; set; }
        public decimal MontoReten { get; set; }
        public decimal MontoObj { get; set; }
        public decimal Sustraen { get; set; }
        public string CoIslr { get; set; }
        public int Pagar { get; set; }
        public bool Anulada { get; set; }
        public decimal PorcRetn { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Salestax { get; set; }
        public string Origen { get; set; }
        public string OrigenD { get; set; }

        public virtual Almacen CoSucuNavigation { get; set; }
        public virtual Benefici CodBenNavigation { get; set; }
        public virtual CtaIngr CtaEgreNavigation { get; set; }
    }
}
