using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Prov
    {
        public Prov()
        {
            Art = new HashSet<Art>();
            Compras = new HashSet<Compras>();
            CotizP = new HashSet<CotizP>();
            DevPro = new HashSet<DevPro>();
            DocumCp = new HashSet<DocumCp>();
            ExpImp = new HashSet<ExpImp>();
            NotRec = new HashSet<NotRec>();
            Ordenes = new HashSet<Ordenes>();
            Pagos = new HashSet<Pagos>();
            Placom = new HashSet<Placom>();
            RmaEntp = new HashSet<RmaEntp>();
            RmaProv = new HashSet<RmaProv>();
        }

        public string CoProv { get; set; }
        public string ProvDes { get; set; }
        public string CoSeg { get; set; }
        public string CoZon { get; set; }
        public bool Inactivo { get; set; }
        public string Productos { get; set; }
        public string Direc1 { get; set; }
        public string Direc2 { get; set; }
        public string Telefonos { get; set; }
        public string Fax { get; set; }
        public string Respons { get; set; }
        public DateTime FechaReg { get; set; }
        public string Tipo { get; set; }
        public int ComUltCo { get; set; }
        public DateTime FecUltCo { get; set; }
        public decimal NetUltCo { get; set; }
        public decimal Saldo { get; set; }
        public decimal SaldoIni { get; set; }
        public decimal MontCre { get; set; }
        public int PlazPag { get; set; }
        public decimal DescPpago { get; set; }
        public decimal DescGlob { get; set; }
        public string TipoIva { get; set; }
        public decimal Iva { get; set; }
        public string Rif { get; set; }
        public bool Nacional { get; set; }
        public string DisCen { get; set; }
        public string Nit { get; set; }
        public string Email { get; set; }
        public string CoIngr { get; set; }
        public string Comentario { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string Campo5 { get; set; }
        public string Campo6 { get; set; }
        public string Campo7 { get; set; }
        public string Campo8 { get; set; }
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
        public bool Juridico { get; set; }
        public decimal TipoAdi { get; set; }
        public string Matriz { get; set; }
        public int CoTab { get; set; }
        public string TipoPer { get; set; }
        public string CoPais { get; set; }
        public string Ciudad { get; set; }
        public string Zip { get; set; }
        public string Website { get; set; }
        public string Formtype { get; set; }
        public string Taxid { get; set; }
        public double PorcEsp { get; set; }
        public bool ContribuE { get; set; }

        public virtual CtaIngr CoIngrNavigation { get; set; }
        public virtual Segmento CoSegNavigation { get; set; }
        public virtual Zona CoZonNavigation { get; set; }
        public virtual TipoPro TipoNavigation { get; set; }
        public virtual ICollection<Art> Art { get; set; }
        public virtual ICollection<Compras> Compras { get; set; }
        public virtual ICollection<CotizP> CotizP { get; set; }
        public virtual ICollection<DevPro> DevPro { get; set; }
        public virtual ICollection<DocumCp> DocumCp { get; set; }
        public virtual ICollection<ExpImp> ExpImp { get; set; }
        public virtual ICollection<NotRec> NotRec { get; set; }
        public virtual ICollection<Ordenes> Ordenes { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
        public virtual ICollection<Placom> Placom { get; set; }
        public virtual ICollection<RmaEntp> RmaEntp { get; set; }
        public virtual ICollection<RmaProv> RmaProv { get; set; }
    }
}
