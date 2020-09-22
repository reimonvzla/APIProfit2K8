using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengRmp
    {
        public int RmaNum { get; set; }
        public int RengNum { get; set; }
        public string Serial { get; set; }
        public string DocTipE { get; set; }
        public int DocNumE { get; set; }
        public string CoArt { get; set; }
        public string TipoDoc { get; set; }
        public int NumDoc { get; set; }
        public DateTime FecDocE { get; set; }
        public string CoFalla { get; set; }
        public string Status { get; set; }
        public DateTime FecEmis { get; set; }
        public string CoReem { get; set; }
        public string Treemplazo { get; set; }
        public string Comentario { get; set; }
        public string CoSucu { get; set; }
        public bool Seleccion { get; set; }
        public string CoAlma { get; set; }
        public string DesArt { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
        public virtual Art CoArtNavigation { get; set; }
        public virtual RmaReep CoReemNavigation { get; set; }
        public virtual RmaProv RmaNumNavigation { get; set; }
    }
}
