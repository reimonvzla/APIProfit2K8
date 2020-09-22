using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengTab
    {
        public int CoTab { get; set; }
        public int RengNum { get; set; }
        public string CoIslr { get; set; }
        public double PorcRet { get; set; }
        public double PorcImp { get; set; }
        public double Sustraen { get; set; }
        public string IslrDes { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ConIslr CoIslrNavigation { get; set; }
    }
}
