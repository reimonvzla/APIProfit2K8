using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengCos
    {
        public int CostNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public decimal MpCant { get; set; }
        public decimal MoCant { get; set; }
        public decimal GfCant { get; set; }
        public decimal Total { get; set; }
        public decimal MpCantOm { get; set; }
        public decimal MoCantOm { get; set; }
        public decimal GfCantOm { get; set; }
        public decimal TotalOm { get; set; }
        public Guid Rowguid { get; set; }
        public decimal PorMp { get; set; }
        public decimal PorMo { get; set; }
        public decimal PorGf { get; set; }
        public decimal PorMpOm { get; set; }
        public decimal PorMoOm { get; set; }
        public decimal PorGfOm { get; set; }
        public decimal MenCant { get; set; }
        public decimal MemCant { get; set; }
        public decimal OiCant { get; set; }
        public decimal MenCantOm { get; set; }
        public decimal MemCantOm { get; set; }
        public decimal OiCantOm { get; set; }
        public decimal PorMen { get; set; }
        public decimal PorMem { get; set; }
        public decimal PorOi { get; set; }
        public decimal PorMenOm { get; set; }
        public decimal PorMemOm { get; set; }
        public decimal PorOiOm { get; set; }
        public string CoUni { get; set; }
        public decimal TotalUni { get; set; }

        public virtual Spcostest CostNumNavigation { get; set; }
    }
}
