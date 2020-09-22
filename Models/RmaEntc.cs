﻿using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RmaEntc
    {
        public RmaEntc()
        {
            RengEnc = new HashSet<RengEnc>();
        }

        public int RmaNum { get; set; }
        public DateTime FecEmis { get; set; }
        public string CoCli { get; set; }
        public string Nombre { get; set; }
        public string Rif { get; set; }
        public string Nit { get; set; }
        public string Comentario { get; set; }
        public string Descrip { get; set; }
        public double Tasa { get; set; }
        public string Moneda { get; set; }
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
        public string CoSucu { get; set; }
        public bool Anulada { get; set; }
        public Guid Rowguid { get; set; }
        public string Transfe { get; set; }
        public int AjuAdm { get; set; }
        public int AjuRma { get; set; }

        public virtual Clientes CoCliNavigation { get; set; }
        public virtual Moneda MonedaNavigation { get; set; }
        public virtual ICollection<RengEnc> RengEnc { get; set; }
    }
}
