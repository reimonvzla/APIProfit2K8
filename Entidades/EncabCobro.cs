namespace APIProfit2K8.Entidades
{
    using System;
    using System.Collections.Generic;

    public class EncabCobro
    {

        public int CobNum { get; set; }
        public string Recibo { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public DateTime FecCob { get; set; }
        public bool Anulado { get; set; }
        public decimal Monto { get; set; }
        public decimal Dppago { get; set; }
        public decimal MontNcr { get; set; }
        public int Ncr { get; set; }
        public decimal TcomiPorc { get; set; }
        public decimal TcomiLine { get; set; }
        public decimal TcomiArt { get; set; }
        public decimal TcomiConc { get; set; }
        public DateTime Feccom { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
        public int Numcom { get; set; }
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
        public bool Recargo { get; set; }
        public int AdelNum { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }
        public string Descrip { get; set; }
        public int NumDev { get; set; }
        public bool Devdinero { get; set; }
        public int NumTurno { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Origen { get; set; }
        public string OrigenD { get; set; }
        public ICollection<DetaCobro> DetaCobro { get; set; }
        public ICollection<FormaPagoCobro> FormaPagoCobro { get; set; }

    }
}
