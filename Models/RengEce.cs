using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengEce
    {
        public int CoCed { get; set; }
        public int RengNum { get; set; }
        public string CoEmp { get; set; }
        public int Cantidad { get; set; }
        public decimal Horas { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spced CoCedNavigation { get; set; }
        public virtual Spemple CoEmpNavigation { get; set; }
    }
}
