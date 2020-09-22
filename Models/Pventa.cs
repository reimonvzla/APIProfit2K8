using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Pventa
    {
        public int FactNum { get; set; }
        public bool Contrib { get; set; }
        public string Nombre { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public int NumContro { get; set; }
        public string Numcon { get; set; }
        public string Status { get; set; }
        public string Comentario { get; set; }
        public string Descrip { get; set; }
        public double Saldo { get; set; }
        public DateTime FecEmis { get; set; }
        public DateTime FecVenc { get; set; }
        public string CoCli { get; set; }
        public string CoVen { get; set; }
        public string CoTran { get; set; }
        public string DirEnt { get; set; }
        public string FormaPag { get; set; }
        public double TotBruto { get; set; }
        public double TotNeto { get; set; }
        public double GlobDesc { get; set; }
        public double TotReca { get; set; }
        public string PorcGdesc { get; set; }
        public string PorcReca { get; set; }
        public double TotalUc { get; set; }
        public double TotalCp { get; set; }
        public double TotFlete { get; set; }
        public double MontoDev { get; set; }
        public double Totklu { get; set; }
        public bool Anulada { get; set; }
        public bool Impresa { get; set; }
        public double Iva { get; set; }
        public double IvaDev { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public double Tasa { get; set; }
        public string Moneda { get; set; }
        public string DisCen { get; set; }
        public double Vuelto { get; set; }
        public int Seriales { get; set; }
        public double Tasag { get; set; }
        public double Tasag10 { get; set; }
        public double Tasag20 { get; set; }
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
        public double MonIlc { get; set; }
        public double Otros1 { get; set; }
        public double Otros2 { get; set; }
        public double Otros3 { get; set; }
        public int NumTurno { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
        public string Salestax { get; set; }
        public string Origen { get; set; }
        public string OrigenD { get; set; }
        public string Telefono { get; set; }
    }
}
