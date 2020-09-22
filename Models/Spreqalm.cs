using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Spreqalm
    {
        public int ReqNum { get; set; }
        public DateTime Fecha { get; set; }
        public string AlmOrig { get; set; }
        public string AlmDest { get; set; }
        public string MotivoGlo { get; set; }
        public bool Confirma { get; set; }
        public DateTime FecConf { get; set; }
        public bool Inactivo { get; set; }
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
        public string Reqnfe { get; set; }
        public int Seriales { get; set; }
        public string CoSucu { get; set; }
        public bool Anulada { get; set; }
        public string DisCen { get; set; }
        public DateTime Feccom { get; set; }
        public int Numcom { get; set; }
        public int OdpNum { get; set; }
        public string Comentario { get; set; }
        public int TrasNum { get; set; }
        public Guid Rowguid { get; set; }
        public string Trasnfe { get; set; }
    }
}
