using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Ambmov
    {
        public string AmbUsua { get; set; }
        public string TipoMovi { get; set; }
        public bool? MovNumv { get; set; }
        public bool? Codigov { get; set; }
        public bool Codigod { get; set; }
        public string Codigo { get; set; }
        public bool? TipoOpv { get; set; }
        public bool TipoOpd { get; set; }
        public string TipoOp { get; set; }
        public bool? FormaPagv { get; set; }
        public bool FormaPagd { get; set; }
        public string FormaPag { get; set; }
        public bool? Fechav { get; set; }
        public bool? DocNumv { get; set; }
        public bool? Descripv { get; set; }
        public bool? Montov { get; set; }
        public bool? CtaEgrev { get; set; }
        public bool CtaEgred { get; set; }
        public string CtaEgre { get; set; }
        public bool? BancTarjv { get; set; }
        public bool BancTarjd { get; set; }
        public string BancTarj { get; set; }
        public bool? BtReverv { get; set; }
        public bool? BtAnulav { get; set; }
        public bool? Tasav { get; set; }
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
    }
}
