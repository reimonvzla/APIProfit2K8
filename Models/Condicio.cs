using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Condicio
    {
        public Condicio()
        {
            Compras = new HashSet<Compras>();
            CotizC = new HashSet<CotizC>();
            CotizP = new HashSet<CotizP>();
            DevCli = new HashSet<DevCli>();
            DevPro = new HashSet<DevPro>();
            Factura = new HashSet<Factura>();
            NotDep = new HashSet<NotDep>();
            NotEnt = new HashSet<NotEnt>();
            NotRec = new HashSet<NotRec>();
            Ordenes = new HashSet<Ordenes>();
            Pedidos = new HashSet<Pedidos>();
            Placom = new HashSet<Placom>();
            Plavent = new HashSet<Plavent>();
        }

        public string CoCond { get; set; }
        public string CondDes { get; set; }
        public int DiasCred { get; set; }
        public string DisCen { get; set; }
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
        public byte[] RowId { get; set; }

        public virtual ICollection<Compras> Compras { get; set; }
        public virtual ICollection<CotizC> CotizC { get; set; }
        public virtual ICollection<CotizP> CotizP { get; set; }
        public virtual ICollection<DevCli> DevCli { get; set; }
        public virtual ICollection<DevPro> DevPro { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<NotDep> NotDep { get; set; }
        public virtual ICollection<NotEnt> NotEnt { get; set; }
        public virtual ICollection<NotRec> NotRec { get; set; }
        public virtual ICollection<Ordenes> Ordenes { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Placom> Placom { get; set; }
        public virtual ICollection<Plavent> Plavent { get; set; }
    }
}
