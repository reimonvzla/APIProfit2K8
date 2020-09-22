using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Aranc
    {
        public string CoArt { get; set; }
        public string CoAra { get; set; }
        public string DesAra { get; set; }
        public decimal PorcAra { get; set; }
        public string Calidad { get; set; }
        public string Nivel { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
