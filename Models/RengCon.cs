using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengCon
    {
        public RengCon()
        {
            ConcBan = new HashSet<ConcBan>();
        }

        public string CodCta { get; set; }
        public int Mes { get; set; }
        public int Ano { get; set; }
        public int RengNum { get; set; }
        public DateTime FecMov { get; set; }
        public string TipoOp { get; set; }
        public string DocNum { get; set; }
        public string Descrip { get; set; }
        public decimal MontoD { get; set; }
        public decimal MontoH { get; set; }
        public decimal Idb { get; set; }
        public int DepCon { get; set; }
        public string Origen { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ConcAut ConcAut { get; set; }
        public virtual ICollection<ConcBan> ConcBan { get; set; }
    }
}
