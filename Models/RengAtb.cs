using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengAtb
    {
        public string CoAtriv { get; set; }
        public string CoTar { get; set; }
        public int RengNum { get; set; }
        public string Valor { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spatriv CoAtrivNavigation { get; set; }
        public virtual Sptar CoTarNavigation { get; set; }
    }
}
