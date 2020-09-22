using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengEmb
    {
        public int ExpNum { get; set; }
        public int RengNum { get; set; }
        public int TipoTra { get; set; }
        public int FactNum { get; set; }
        public string NumDoc { get; set; }
        public string EmpTra { get; set; }
        public string VehNom { get; set; }
        public DateTime FecEtd { get; set; }
        public string LugEmb { get; set; }
        public DateTime FecEta { get; set; }
        public string CantCon { get; set; }
        public decimal PesoVo { get; set; }
        public decimal PesoTo { get; set; }
        public decimal VolTot { get; set; }
        public string CoUni { get; set; }
        public int CantEmp { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Unidades CoUniNavigation { get; set; }
        public virtual ExpImp ExpNumNavigation { get; set; }
    }
}
