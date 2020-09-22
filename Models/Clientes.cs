using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Clientes
    {
        public Clientes()
        {
            Cobros = new HashSet<Cobros>();
            CotizC = new HashSet<CotizC>();
            DevCli = new HashSet<DevCli>();
            DocumCc = new HashSet<DocumCc>();
            Factura = new HashSet<Factura>();
            NotDep = new HashSet<NotDep>();
            NotEnt = new HashSet<NotEnt>();
            Pedidos = new HashSet<Pedidos>();
            Plavent = new HashSet<Plavent>();
            RmaCli = new HashSet<RmaCli>();
            RmaEntc = new HashSet<RmaEntc>();
        }

        public string CoCli { get; set; }
        public string Tipo { get; set; }
        public string CliDes { get; set; }
        public string Direc1 { get; set; }
        public string Direc2 { get; set; }
        public string Telefonos { get; set; }
        public string Fax { get; set; }
        public bool Inactivo { get; set; }
        public string Comentario { get; set; }
        public string Respons { get; set; }
        public DateTime FechaReg { get; set; }
        public int Puntaje { get; set; }
        public double Saldo { get; set; }
        public double SaldoIni { get; set; }
        public int FacUltVe { get; set; }
        public DateTime FecUltVe { get; set; }
        public decimal NetUltVe { get; set; }
        public decimal MontCre { get; set; }
        public int PlazPag { get; set; }
        public decimal DescPpago { get; set; }
        public string CoZon { get; set; }
        public string CoSeg { get; set; }
        public string CoVen { get; set; }
        public decimal DescGlob { get; set; }
        public string HorarCaja { get; set; }
        public string FrecuVist { get; set; }
        public bool Lunes { get; set; }
        public bool Martes { get; set; }
        public bool Miercoles { get; set; }
        public bool Jueves { get; set; }
        public bool Viernes { get; set; }
        public bool Sabado { get; set; }
        public bool Domingo { get; set; }
        public string DirEnt2 { get; set; }
        public string TipoIva { get; set; }
        public decimal Iva { get; set; }
        public string Rif { get; set; }
        public bool Contribu { get; set; }
        public string DisCen { get; set; }
        public string Nit { get; set; }
        public string Email { get; set; }
        public string CoIngr { get; set; }
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
        public string Serialp { get; set; }
        public bool Valido { get; set; }
        public byte[] RowId { get; set; }
        public string Estado { get; set; }
        public int Id { get; set; }
        public string CoPais { get; set; }
        public string Ciudad { get; set; }
        public string Zip { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Website { get; set; }
        public string Salestax { get; set; }
        public bool Sincredito { get; set; }
        public double PorcEsp { get; set; }
        public bool ContribuE { get; set; }

        public virtual CtaIngr CoIngrNavigation { get; set; }
        public virtual Segmento CoSegNavigation { get; set; }
        public virtual Vendedor CoVenNavigation { get; set; }
        public virtual Zona CoZonNavigation { get; set; }
        public virtual TipoCli TipoNavigation { get; set; }
        public virtual ICollection<Cobros> Cobros { get; set; }
        public virtual ICollection<CotizC> CotizC { get; set; }
        public virtual ICollection<DevCli> DevCli { get; set; }
        public virtual ICollection<DocumCc> DocumCc { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<NotDep> NotDep { get; set; }
        public virtual ICollection<NotEnt> NotEnt { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Plavent> Plavent { get; set; }
        public virtual ICollection<RmaCli> RmaCli { get; set; }
        public virtual ICollection<RmaEntc> RmaEntc { get; set; }
    }
}
