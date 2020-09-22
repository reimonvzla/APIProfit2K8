using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengPla
    {
        public int PlaNum { get; set; }
        public int RengNum { get; set; }
        public bool Xstock { get; set; }
        public string CoArt { get; set; }
        public decimal M1 { get; set; }
        public decimal M2 { get; set; }
        public decimal M3 { get; set; }
        public decimal M4 { get; set; }
        public decimal M5 { get; set; }
        public decimal M6 { get; set; }
        public decimal M7 { get; set; }
        public decimal M8 { get; set; }
        public decimal M9 { get; set; }
        public decimal M10 { get; set; }
        public decimal M11 { get; set; }
        public decimal M12 { get; set; }
        public decimal D1 { get; set; }
        public decimal D2 { get; set; }
        public decimal D3 { get; set; }
        public decimal D4 { get; set; }
        public decimal D5 { get; set; }
        public decimal D6 { get; set; }
        public decimal D7 { get; set; }
        public decimal D8 { get; set; }
        public decimal D9 { get; set; }
        public decimal D10 { get; set; }
        public decimal D11 { get; set; }
        public decimal D12 { get; set; }
        public int Enero { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spplanenc PlaNumNavigation { get; set; }
    }
}
