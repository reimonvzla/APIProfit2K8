using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengEmp
    {
        public int EmpNum { get; set; }
        public int RengNum { get; set; }
        public string CoArt { get; set; }
        public decimal TotalArt { get; set; }
        public decimal StotalArt { get; set; }
        public decimal PrecVta { get; set; }
        public string Unid { get; set; }
        public int NumBlto { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public Guid Rowguid { get; set; }
        public string CoAlma { get; set; }
        public decimal CantOrgt { get; set; }
        public decimal CantOrgs { get; set; }
        public int Agrupar { get; set; }
        public string UnidR { get; set; }
        public int NroReng { get; set; }

        public virtual Empaques EmpNumNavigation { get; set; }
    }
}
