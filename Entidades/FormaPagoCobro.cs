namespace APIProfit2K8.Entidades
{
    using APIProfit2K8.Models;
    using System;
    using System.Collections.Generic;

    public class FormaPagoCobro
    {
        public int CobNum { get; set; }
        public int RengNum { get; set; }
        public string TipCob { get; set; }
        public int Movi { get; set; }
        public string NumDoc { get; set; }
        public decimal MontDoc { get; set; }
        public decimal MontTmp { get; set; }
        public string Moneda { get; set; }
        public string Banco { get; set; }
        public string CodCaja { get; set; }
        public string DesCaja { get; set; }
        public DateTime FecCheq { get; set; }
        public string NombreBan { get; set; }
        public string Numero { get; set; }
        public bool Devuelto { get; set; }
        public Guid Rowguid { get; set; }
        public string Operador { get; set; }
        public string Clave { get; set; }
        public virtual EncabCobro EncabCobro { get; set; }
        public IEnumerable<MovCaj> MovCaj { get; set; }
        public IEnumerable<MovBan> MovBan { get; set; }

    }
}
