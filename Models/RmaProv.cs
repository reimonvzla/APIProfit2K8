using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RmaProv
    {
        public RmaProv()
        {
            RengRmp = new HashSet<RengRmp>();
        }

        public int RmaNum { get; set; }
        public DateTime FecEmis { get; set; }
        public string Status { get; set; }
        public string CoProv { get; set; }
        public string RmaProv1 { get; set; }
        public string Comentario { get; set; }
        public string Descrip { get; set; }
        public string CoTran { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }
        public string Transfe { get; set; }

        public virtual Prov CoProvNavigation { get; set; }
        public virtual Transpor CoTranNavigation { get; set; }
        public virtual ICollection<RengRmp> RengRmp { get; set; }
    }
}
