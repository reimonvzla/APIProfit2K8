using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengAra
    {
        public string CoArt { get; set; }
        public string RengAra1 { get; set; }
        public string DesReng { get; set; }
        public string CoConv { get; set; }
        public decimal PorcAra { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual ConvImp CoConvNavigation { get; set; }
    }
}
