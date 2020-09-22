using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Tabulado
    {
        public Tabulado()
        {
            Art = new HashSet<Art>();
            DocumCc = new HashSet<DocumCc>();
            DocumCp = new HashSet<DocumCp>();
            RengCac = new HashSet<RengCac>();
            RengDvc = new HashSet<RengDvc>();
            RengFac = new HashSet<RengFac>();
            RengNdd = new HashSet<RengNdd>();
            RengPed = new HashSet<RengPed>();
        }

        public string Tipo { get; set; }
        public string Descripcio { get; set; }
        public decimal PorcVent { get; set; }
        public decimal PorcComp { get; set; }
        public decimal PorcCxs { get; set; }
        public decimal PorcOtro { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }

        public virtual ICollection<Art> Art { get; set; }
        public virtual ICollection<DocumCc> DocumCc { get; set; }
        public virtual ICollection<DocumCp> DocumCp { get; set; }
        public virtual ICollection<RengCac> RengCac { get; set; }
        public virtual ICollection<RengDvc> RengDvc { get; set; }
        public virtual ICollection<RengFac> RengFac { get; set; }
        public virtual ICollection<RengNdd> RengNdd { get; set; }
        public virtual ICollection<RengPed> RengPed { get; set; }
    }
}
