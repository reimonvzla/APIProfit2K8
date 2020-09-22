using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Cuentas
    {
        public Cuentas()
        {
            Chequeras = new HashSet<Chequeras>();
            ConcAut = new HashSet<ConcAut>();
            DepCaj = new HashSet<DepCaj>();
            MovBan = new HashSet<MovBan>();
        }

        public string CodCta { get; set; }
        public string CoBanco { get; set; }
        public string NumCta { get; set; }
        public string DisCen { get; set; }
        public string Sucursal { get; set; }
        public string CtaContab { get; set; }
        public string Telefono { get; set; }
        public DateTime MesIni { get; set; }
        public decimal SaldoI { get; set; }
        public decimal SaldoIc { get; set; }
        public decimal SaldoA { get; set; }
        public decimal SaldoC { get; set; }
        public string Moneda { get; set; }
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
        public bool Inactivo { get; set; }
        public byte[] RowId { get; set; }
        public bool UsaChra { get; set; }
        public string EjecCu { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public decimal SaldoCo { get; set; }
        public string TipoCu { get; set; }
        public DateTime Fecini { get; set; }
        public DateTime FecChra { get; set; }
        public bool Foranea { get; set; }

        public virtual Bancos CoBancoNavigation { get; set; }
        public virtual ICollection<Chequeras> Chequeras { get; set; }
        public virtual ICollection<ConcAut> ConcAut { get; set; }
        public virtual ICollection<DepCaj> DepCaj { get; set; }
        public virtual ICollection<MovBan> MovBan { get; set; }
    }
}
