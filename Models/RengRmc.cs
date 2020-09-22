using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengRmc
    {
        public int RmaNum { get; set; }
        public int RengNum { get; set; }
        public string Serial { get; set; }
        public string DocTipS { get; set; }
        public int DocNumS { get; set; }
        public string CoArt { get; set; }
        public string TipoDoc { get; set; }
        public int NumDoc { get; set; }
        public DateTime FecDocS { get; set; }
        public double TiempoGar { get; set; }
        public DateTime FecVenc { get; set; }
        public string CoFalla { get; set; }
        public string Status { get; set; }
        public string CoProv { get; set; }
        public DateTime FecEntreg { get; set; }
        public int RmaNumPr { get; set; }
        public string CoRevi { get; set; }
        public string Revisado { get; set; }
        public string CoReem { get; set; }
        public string Treemplazo { get; set; }
        public string Comentario { get; set; }
        public string CoTec { get; set; }
        public bool Seleccion { get; set; }
        public string CoAlma { get; set; }
        public string DesArt { get; set; }
        public Guid Rowguid { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual SubAlma CoAlmaNavigation { get; set; }
        public virtual Art CoArtNavigation { get; set; }
        public virtual RmaReem CoReemNavigation { get; set; }
        public virtual RmaRevi CoReviNavigation { get; set; }
        public virtual Tecnico CoTecNavigation { get; set; }
        public virtual RmaCli RmaNumNavigation { get; set; }
    }
}
