using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Moneda
    {
        public Moneda()
        {
            Ajuste = new HashSet<Ajuste>();
            Cobros = new HashSet<Cobros>();
            Compras = new HashSet<Compras>();
            CotizC = new HashSet<CotizC>();
            CotizP = new HashSet<CotizP>();
            DepCaj = new HashSet<DepCaj>();
            DevCli = new HashSet<DevCli>();
            DevPro = new HashSet<DevPro>();
            DocumCc = new HashSet<DocumCc>();
            DocumCp = new HashSet<DocumCp>();
            Factura = new HashSet<Factura>();
            Fisico = new HashSet<Fisico>();
            GeneKit = new HashSet<GeneKit>();
            Import = new HashSet<Import>();
            MovBan = new HashSet<MovBan>();
            MovCaj = new HashSet<MovCaj>();
            NotDep = new HashSet<NotDep>();
            NotEnt = new HashSet<NotEnt>();
            NotRec = new HashSet<NotRec>();
            Ordenes = new HashSet<Ordenes>();
            Pagos = new HashSet<Pagos>();
            Pedidos = new HashSet<Pedidos>();
            Placom = new HashSet<Placom>();
            Plavent = new HashSet<Plavent>();
            RengAco = new HashSet<RengAco>();
            RengAim = new HashSet<RengAim>();
            RmaEntc = new HashSet<RmaEntc>();
            RmaEntp = new HashSet<RmaEntp>();
            Tasas = new HashSet<Tasas>();
        }

        public string CoMone { get; set; }
        public string MoneDes { get; set; }
        public decimal Cambio { get; set; }
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

        public virtual ICollection<Ajuste> Ajuste { get; set; }
        public virtual ICollection<Cobros> Cobros { get; set; }
        public virtual ICollection<Compras> Compras { get; set; }
        public virtual ICollection<CotizC> CotizC { get; set; }
        public virtual ICollection<CotizP> CotizP { get; set; }
        public virtual ICollection<DepCaj> DepCaj { get; set; }
        public virtual ICollection<DevCli> DevCli { get; set; }
        public virtual ICollection<DevPro> DevPro { get; set; }
        public virtual ICollection<DocumCc> DocumCc { get; set; }
        public virtual ICollection<DocumCp> DocumCp { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<Fisico> Fisico { get; set; }
        public virtual ICollection<GeneKit> GeneKit { get; set; }
        public virtual ICollection<Import> Import { get; set; }
        public virtual ICollection<MovBan> MovBan { get; set; }
        public virtual ICollection<MovCaj> MovCaj { get; set; }
        public virtual ICollection<NotDep> NotDep { get; set; }
        public virtual ICollection<NotEnt> NotEnt { get; set; }
        public virtual ICollection<NotRec> NotRec { get; set; }
        public virtual ICollection<Ordenes> Ordenes { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Placom> Placom { get; set; }
        public virtual ICollection<Plavent> Plavent { get; set; }
        public virtual ICollection<RengAco> RengAco { get; set; }
        public virtual ICollection<RengAim> RengAim { get; set; }
        public virtual ICollection<RmaEntc> RmaEntc { get; set; }
        public virtual ICollection<RmaEntp> RmaEntp { get; set; }
        public virtual ICollection<Tasas> Tasas { get; set; }
    }
}
