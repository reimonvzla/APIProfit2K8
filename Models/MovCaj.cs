using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class MovCaj
    {
        public int MovNum { get; set; }
        public string Codigo { get; set; }
        public int DepNum { get; set; }
        public int RengNum { get; set; }
        public int MovAfec { get; set; }
        public decimal MonDep { get; set; }
        public string Origen { get; set; }
        public string TipoOp { get; set; }
        public string FormaPag { get; set; }
        public DateTime Fecha { get; set; }
        public string DocNum { get; set; }
        public string Descrip { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public string CtaEgre { get; set; }
        public int CobPag { get; set; }
        public bool OriDep { get; set; }
        public int DepCon { get; set; }
        public string BancTarj { get; set; }
        public string CodIngben { get; set; }
        public DateTime FechaChe { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public string DisCen { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
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
        public bool Anulado { get; set; }
        public int NumTurno { get; set; }
        public int MovtOri { get; set; }
        public int MovtGen { get; set; }
        public bool Tracaja { get; set; }
        public string Operador { get; set; }
        public string Clave { get; set; }
        public string Moneda2 { get; set; }
        public decimal Tasa2 { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public bool DocSel { get; set; }

        public virtual Cajas CodigoNavigation { get; set; }
        public virtual CtaIngr CtaEgreNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
    }
}
