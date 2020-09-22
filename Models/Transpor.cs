using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Transpor
    {
        public Transpor()
        {
            CotizC = new HashSet<CotizC>();
            DevCli = new HashSet<DevCli>();
            Factura = new HashSet<Factura>();
            NotDep = new HashSet<NotDep>();
            NotEnt = new HashSet<NotEnt>();
            Pedidos = new HashSet<Pedidos>();
            Plavent = new HashSet<Plavent>();
            RmaProv = new HashSet<RmaProv>();
        }

        public string CoTran { get; set; }
        public string DesTran { get; set; }
        public string RespTra { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string DisCen { get; set; }
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

        public virtual ICollection<CotizC> CotizC { get; set; }
        public virtual ICollection<DevCli> DevCli { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<NotDep> NotDep { get; set; }
        public virtual ICollection<NotEnt> NotEnt { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Plavent> Plavent { get; set; }
        public virtual ICollection<RmaProv> RmaProv { get; set; }
    }
}
