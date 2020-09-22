using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengOdp
    {
        public int OdpNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public string CoUni { get; set; }
        public Guid Rowguid { get; set; }
        public decimal CantReq { get; set; }
        public decimal CantEnt { get; set; }
        public decimal CantEnt2 { get; set; }
        public decimal CantCom { get; set; }
        public decimal CantCom2 { get; set; }
        public decimal CantMax { get; set; }
        public decimal CantDev { get; set; }
        public decimal CantDev2 { get; set; }
        public decimal CantXde { get; set; }
        public decimal CantXde2 { get; set; }
        public string DisCen { get; set; }
        public int Subced { get; set; }
        public decimal TotalUni { get; set; }
        public string CoTar { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual Spodp OdpNumNavigation { get; set; }
    }
}
