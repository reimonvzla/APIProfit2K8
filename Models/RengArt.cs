using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengArt
    {
        public string CoArt { get; set; }
        public int RengNum { get; set; }
        public string CodRelac { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Art CoArtNavigation { get; set; }
    }
}
