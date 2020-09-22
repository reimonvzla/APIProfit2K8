using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class HistPlan
    {
        public string IdHist { get; set; }
        public string CoPlan { get; set; }
        public string PlanNum { get; set; }
        public string DesHist { get; set; }
        public string XmlCont { get; set; }
        public DateTime GenFec { get; set; }
        public string MesPlan { get; set; }
        public string AnoPlan { get; set; }
        public DateTime? CanFech { get; set; }
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

        public virtual PlanFis CoPlanNavigation { get; set; }
    }
}
