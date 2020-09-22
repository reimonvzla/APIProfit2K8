using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Formatos
    {
        public string TipoFor { get; set; }
        public string CoFor { get; set; }
        public string Descrip { get; set; }
        public string GuardoEn { get; set; }
        public int NroLin { get; set; }
        public int LinEncab { get; set; }
        public int LinCuerpo { get; set; }
        public string TipoLetra { get; set; }
        public int ColuObse { get; set; }
        public int CantObse { get; set; }
        public string LetrObse { get; set; }
        public int CantReng { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
    }
}
