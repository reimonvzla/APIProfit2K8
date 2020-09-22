using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengAtc
    {
        public int CoCed { get; set; }
        public int RengNum { get; set; }
        public string CoAtriv { get; set; }
        public string Valor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spatriv CoAtrivNavigation { get; set; }
        public virtual Spced CoCedNavigation { get; set; }
    }
}
