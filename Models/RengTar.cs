using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengTar
    {
        public string CoTar { get; set; }
        public int RengNum { get; set; }
        public string CoMaq { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Spmaq CoMaqNavigation { get; set; }
        public virtual Sptar CoTarNavigation { get; set; }
    }
}
