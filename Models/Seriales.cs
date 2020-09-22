using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Seriales
    {
        public int Contador { get; set; }
        public int NumGara { get; set; }
        public string CoArt { get; set; }
        public string Serial { get; set; }
        public string DocTipE { get; set; }
        public int DocNumE { get; set; }
        public string DocTipS { get; set; }
        public int DocNumS { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoAlma { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
    }
}
