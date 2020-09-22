using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengPve
    {
        public int FactNum { get; set; }
        public int RengNum { get; set; }
        public string DisCen { get; set; }
        public string TipoDoc { get; set; }
        public int RengDoc { get; set; }
        public int NumDoc { get; set; }
        public string CoArt { get; set; }
        public string CoAlma { get; set; }
        public double TotalArt { get; set; }
        public double StotalArt { get; set; }
        public double Pendiente { get; set; }
        public string UniVenta { get; set; }
        public double PrecVta { get; set; }
        public string PorcDesc { get; set; }
        public string TipoImp { get; set; }
        public double Isv { get; set; }
        public double RengNeto { get; set; }
        public double CosProUn { get; set; }
        public double UltCosUn { get; set; }
        public double UltCosOm { get; set; }
        public double CosProOm { get; set; }
        public double TotalDev { get; set; }
        public double MontoDev { get; set; }
        public double PrecVta2 { get; set; }
        public bool Anulado { get; set; }
        public string DesArt { get; set; }
        public bool Seleccion { get; set; }
        public double CantImp { get; set; }
        public string Comentario { get; set; }
        public double TotalUni { get; set; }
        public double MonIlc { get; set; }
        public double Otros { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public double Pendiente2 { get; set; }
        public string TipoDoc2 { get; set; }
        public int RengDoc2 { get; set; }
        public int NumDoc2 { get; set; }
        public string CoAlma2 { get; set; }
        public Guid Rowguid { get; set; }
    }
}
