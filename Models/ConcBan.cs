using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class ConcBan
    {
        public string CodCta { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int RengNum { get; set; }
        public int MovNum { get; set; }
        public DateTime FecConc { get; set; }
        public bool ConAuto { get; set; }
        public Guid Rowguid { get; set; }

        public virtual MovBan MovNumNavigation { get; set; }
        public virtual RengCon RengCon { get; set; }
    }
}
