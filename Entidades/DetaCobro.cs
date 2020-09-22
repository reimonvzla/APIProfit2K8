namespace APIProfit2K8.Entidades
{
    using System;

    public class DetaCobro
    {
        public int CobNum { get; set; }
        public int RengNum { get; set; }
        public string TpDocCob { get; set; }
        public int DocNum { get; set; }
        public decimal Neto { get; set; }
        public decimal NetoTmp { get; set; }
        public decimal Dppago { get; set; }
        public int DppagoTmp { get; set; }
        public int RengNcr { get; set; }
        public string CoVen { get; set; }
        public decimal Comis1 { get; set; }
        public decimal Comis2 { get; set; }
        public decimal Comis3 { get; set; }
        public decimal Comis4 { get; set; }
        public string SignAjuC { get; set; }
        public decimal PorcAjuC { get; set; }
        public decimal PorCob { get; set; }
        public decimal ComiCob { get; set; }
        public decimal MontCob { get; set; }
        public bool SinoPago { get; set; }
        public bool SinoReten { get; set; }
        public decimal MontoDppago { get; set; }
        public decimal MontoReten { get; set; }
        public decimal ImpPago { get; set; }
        public decimal MontoObj { get; set; }
        public decimal Isv { get; set; }
        public string NroFact { get; set; }
        public string Moneda { get; set; }
        public decimal Tasa { get; set; }
        public string Numcon { get; set; }
        public decimal Sustraen { get; set; }
        public Guid Rowguid { get; set; }
        public string CoIslr { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public decimal Comis5 { get; set; }
        public decimal Comis6 { get; set; }
        public int FactIva { get; set; }
        public decimal RetIva { get; set; }
        public decimal PorcRetn { get; set; }
        public decimal PorcDesc { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string ProvTer { get; set; }
        public int RengTer { get; set; }
        public DateTime? FecCom { get; set; }

        public virtual EncabCobro EncabCobro { get; set; }
    }
}
