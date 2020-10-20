namespace APIProfit2K8.Entidades
{
    using System;
    using System.Collections.Generic;

    public class EncabDevolucionVenta
    {
        public int FactNum { get; set; }
        public bool Contrib { get; set; }
        public string Nombre { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public int NumControl { get; set; }
        public string Status { get; set; }
        public string Comentario { get; set; }
        public string Descrip { get; set; }
        public decimal Saldo { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public string CoTran { get; set; }
        public string DirEnt { get; set; }
        public string FormaPag { get; set; }
        public decimal? TotBruto { get; set; }
        public decimal? TotNeto { get; set; }
        public decimal GlobDesc { get; set; }
        public decimal TotReca { get; set; }
        public string PorcGdesc { get; set; }
        public string PorcReca { get; set; }
        public decimal TotalUc { get; set; }
        public decimal TotalCp { get; set; }
        public decimal TotFlete { get; set; }
        public decimal MontoDev { get; set; }
        public decimal Totklu { get; set; }
        public bool Anulada { get; set; }
        public bool Impresa { get; set; }
        public decimal Iva { get; set; }
        public decimal IvaDev { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public decimal Tasa { get; set; }
        public string Moneda { get; set; }
        public string DisCen { get; set; }
        public int NcNum { get; set; }
        public int Seriales { get; set; }
        public decimal Tasag { get; set; }
        public decimal Tasag10 { get; set; }
        public decimal Tasag20 { get; set; }
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
        public string Numcon { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }
        public decimal MonIlc { get; set; }
        public decimal Otros1 { get; set; }
        public decimal Otros2 { get; set; }
        public decimal Otros3 { get; set; }
        public int NumCob { get; set; }
        public int MovCaj { get; set; }
        public int MovBan { get; set; }
        public decimal SaldoNcr { get; set; }
        public int NumTurno { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Salestax { get; set; }
        public string Origen { get; set; }
        public string OrigenD { get; set; }
        public string StaProd { get; set; }
        public string Telefono { get; set; }

        public ICollection<DetaDevolucionVenta> DetaDevolucionVenta { get; set; }
    }
}