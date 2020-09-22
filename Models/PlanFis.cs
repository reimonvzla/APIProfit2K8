using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class PlanFis
    {
        public PlanFis()
        {
            HistPlan = new HashSet<HistPlan>();
        }

        public string CoPlan { get; set; }
        public string NomPlan { get; set; }
        public string DesPlan { get; set; }
        public string XmlPlan { get; set; }
        public string XmlPrin { get; set; }
        public string AccPlan { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<HistPlan> HistPlan { get; set; }
    }
}
