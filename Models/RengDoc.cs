using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengDoc
    {
        public int ExpNum { get; set; }
        public int RengNum { get; set; }
        public string TipoDoc { get; set; }
        public string NumDoc { get; set; }
        public DateTime Fecha { get; set; }
        public bool DocCop { get; set; }
        public string DocCom { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ExpImp ExpNumNavigation { get; set; }
    }
}
