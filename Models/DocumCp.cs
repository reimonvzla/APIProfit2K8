using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class DocumCp
    {
        public string TipoDoc { get; set; }
        public int NroDoc { get; set; }
        public bool Anulado { get; set; }
        public int Movi { get; set; }
        public bool Aut { get; set; }
        public string CoCli { get; set; }
        public bool Contrib { get; set; }
        public int Pagar { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public string NroFact { get; set; }
        public string Observa { get; set; }
        public string DocOrig { get; set; }
        public int NroOrig { get; set; }
        public string CoBan { get; set; }
        public string NroChe { get; set; }
        public string CoVen { get; set; }
        public string Tipo { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
        public decimal MontoImp { get; set; }
        public decimal MontoGen { get; set; }
        public decimal MontoA1 { get; set; }
        public decimal MontoA2 { get; set; }
        public decimal MontoBru { get; set; }
        public string Descuentos { get; set; }
        public decimal MontoDes { get; set; }
        public string Recargo { get; set; }
        public decimal MontoRec { get; set; }
        public decimal MontoOtr { get; set; }
        public decimal MontoNet { get; set; }
        public decimal Saldo { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public string DisCen { get; set; }
        public decimal Comis1 { get; set; }
        public decimal Comis2 { get; set; }
        public decimal Comis3 { get; set; }
        public decimal Comis4 { get; set; }
        public decimal Adicional { get; set; }
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
        public decimal MonIlc { get; set; }
        public decimal Otros1 { get; set; }
        public decimal Otros2 { get; set; }
        public decimal Otros3 { get; set; }
        public bool RengSi { get; set; }
        public string NControl { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Salestax { get; set; }
        public string Origen { get; set; }
        public string OrigenD { get; set; }
        public DateTime FecReg { get; set; }
        public string ProvTer { get; set; }
        public int RengTer { get; set; }
        public DateTime Fcomproban { get; set; }
        public string ProPago { get; set; }

        public virtual Prov CoCliNavigation { get; set; }
        public virtual Almacen CoSucuNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
        public virtual Tabulado TipoNavigation { get; set; }
    }
}
