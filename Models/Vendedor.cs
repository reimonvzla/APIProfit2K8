using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Vendedor
    {
        public Vendedor()
        {
            Clientes = new HashSet<Clientes>();
            Cobros = new HashSet<Cobros>();
            CotizC = new HashSet<CotizC>();
            DevCli = new HashSet<DevCli>();
            DocumCc = new HashSet<DocumCc>();
            Factura = new HashSet<Factura>();
            NotDep = new HashSet<NotDep>();
            NotEnt = new HashSet<NotEnt>();
            Pedidos = new HashSet<Pedidos>();
            Plavent = new HashSet<Plavent>();
        }

        public string CoVen { get; set; }
        public string Tipo { get; set; }
        public string VenDes { get; set; }
        public string DisCen { get; set; }
        public string Cedula { get; set; }
        public string Direc1 { get; set; }
        public string Direc2 { get; set; }
        public string Telefonos { get; set; }
        public DateTime FechaReg { get; set; }
        public bool Condic { get; set; }
        public decimal Comision { get; set; }
        public string Comen { get; set; }
        public bool FunCob { get; set; }
        public bool FunVen { get; set; }
        public decimal Comisionv { get; set; }
        public int FacUltVe { get; set; }
        public DateTime FecUltVe { get; set; }
        public decimal NetUltVe { get; set; }
        public string CliUltVe { get; set; }
        public string CtaContab { get; set; }
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
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PswM { get; set; }

        public virtual ICollection<Clientes> Clientes { get; set; }
        public virtual ICollection<Cobros> Cobros { get; set; }
        public virtual ICollection<CotizC> CotizC { get; set; }
        public virtual ICollection<DevCli> DevCli { get; set; }
        public virtual ICollection<DocumCc> DocumCc { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<NotDep> NotDep { get; set; }
        public virtual ICollection<NotEnt> NotEnt { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Plavent> Plavent { get; set; }
    }
}
