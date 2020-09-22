using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class RengDp
    {
        public int DepNum { get; set; }
        public int RengNum { get; set; }
        public string Codigo { get; set; }
        public int MovAfec { get; set; }
        public int MovGene { get; set; }
        public string FormaPag { get; set; }
        public DateTime Fecha { get; set; }
        public string DocNum { get; set; }
        public string Descrip { get; set; }
        public decimal Monto { get; set; }
        public string Origen { get; set; }
        public int CobPag { get; set; }
        public string BancTarj { get; set; }
        public decimal Comision { get; set; }
        public decimal Impuesto { get; set; }
        public Guid Rowguid { get; set; }
        public string TipoPlazo { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }

        public virtual Cajas CodigoNavigation { get; set; }
    }
}
