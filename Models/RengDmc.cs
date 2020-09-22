using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengDmc
    {
        public int DmcNum { get; set; }
        public int RengNum { get; set; }
        public int CanBult { get; set; }
        public string ClaBult { get; set; }
        public string ArtDesc { get; set; }
        public string Arancel { get; set; }
        public string UnidTip { get; set; }
        public int UnidEnt { get; set; }
        public decimal UnidFrc { get; set; }
        public decimal Peso { get; set; }
        public decimal Valor { get; set; }
        public string TipoImp { get; set; }
        public Guid Rowguid { get; set; }
    }
}
