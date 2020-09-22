using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Lote
    {
        public Lote()
        {
            StLote = new HashSet<StLote>();
        }

        public string CoArt { get; set; }
        public string NroLote { get; set; }
        public DateTime FecLote { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public Guid Rowguid { get; set; }
        public decimal PrecVta1 { get; set; }
        public decimal PrecVta2 { get; set; }
        public decimal PrecVta3 { get; set; }
        public decimal PrecVta4 { get; set; }
        public decimal PrecVta5 { get; set; }
        public decimal UltCosUn { get; set; }
        public decimal UltCosOm { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Art CoArtNavigation { get; set; }
        public virtual ICollection<StLote> StLote { get; set; }
    }
}
