﻿using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class CredFis
    {
        public string CoArt { get; set; }
        public bool CredFis1 { get; set; }
        public Guid Rowguid { get; set; }
        public Guid? RowguidCoArt { get; set; }
        public string CoUsIn { get; set; }
        public DateTime? FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime? FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime? FeUsEl { get; set; }
        public string Trasnfe { get; set; }
        public string Revisado { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
    }
}
