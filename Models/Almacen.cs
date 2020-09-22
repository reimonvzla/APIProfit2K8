using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Almacen
    {
        public Almacen()
        {
            Ajuste = new HashSet<Ajuste>();
            Ambtras = new HashSet<Ambtras>();
            Cobros = new HashSet<Cobros>();
            Compras = new HashSet<Compras>();
            CotizC = new HashSet<CotizC>();
            DepCaj = new HashSet<DepCaj>();
            DevCli = new HashSet<DevCli>();
            DevPro = new HashSet<DevPro>();
            DocumCc = new HashSet<DocumCc>();
            DocumCp = new HashSet<DocumCp>();
            Factura = new HashSet<Factura>();
            Fisico = new HashSet<Fisico>();
            ImpMun = new HashSet<ImpMun>();
            NotDep = new HashSet<NotDep>();
            NotEnt = new HashSet<NotEnt>();
            NotRec = new HashSet<NotRec>();
            OrdPago = new HashSet<OrdPago>();
            Ordenes = new HashSet<Ordenes>();
            Pagos = new HashSet<Pagos>();
            Pedidos = new HashSet<Pedidos>();
            Plavent = new HashSet<Plavent>();
            Rentab = new HashSet<Rentab>();
            SubAlma = new HashSet<SubAlma>();
            TurnosicNavigation = new HashSet<Turnosic>();
        }

        public string CoAlma { get; set; }
        public string AlmaDes { get; set; }
        public int NroFact { get; set; }
        public int NumFacIni { get; set; }
        public int NumFacFin { get; set; }
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
        public int NcNum { get; set; }
        public int NdNum { get; set; }
        public int AjusNum { get; set; }
        public int TrasNum { get; set; }
        public int FisiNum { get; set; }
        public int NumKit { get; set; }
        public int GenkNum { get; set; }
        public int FactNum { get; set; }
        public int PedNum { get; set; }
        public int CotcNum { get; set; }
        public int DevcNum { get; set; }
        public int NdeNum { get; set; }
        public int NddNum { get; set; }
        public int PostNum { get; set; }
        public int CfxgNum { get; set; }
        public int ChdvNum { get; set; }
        public int GiroNum { get; set; }
        public int RetenNum { get; set; }
        public int CbNum { get; set; }
        public int MovbNum { get; set; }
        public int MovcNum { get; set; }
        public int OrdpNum { get; set; }
        public int DepcNum { get; set; }
        public int CompNum { get; set; }
        public int OrdNum { get; set; }
        public int CotpNum { get; set; }
        public int DevpNum { get; set; }
        public int NdrNum { get; set; }
        public int Postcppnum { get; set; }
        public int CcxgNum { get; set; }
        public int Chdvcppnum { get; set; }
        public int Girocppnum { get; set; }
        public int NccppNum { get; set; }
        public int NdcppNum { get; set; }
        public int Retencppnum { get; set; }
        public int PgNum { get; set; }
        public int AjuPosm { get; set; }
        public int AjuPosa { get; set; }
        public int AjuNegm { get; set; }
        public int AjuNega { get; set; }
        public int AjuPosmc { get; set; }
        public int AjuPosac { get; set; }
        public int AjuNegmc { get; set; }
        public int AjuNegac { get; set; }
        public int Pventa { get; set; }
        public int Turnosic { get; set; }
        public int PlvNum { get; set; }
        public int PlcNum { get; set; }
        public int Tabislr { get; set; }
        public int ImpNum { get; set; }
        public int RmaCli { get; set; }
        public int RmaProv { get; set; }
        public int RmaEntc { get; set; }
        public int RmaEntp { get; set; }
        public int RmaRegs { get; set; }
        public string FactS1 { get; set; }
        public string FactS2 { get; set; }
        public string FactS3 { get; set; }
        public string FactS4 { get; set; }
        public string FactS5 { get; set; }
        public string NdeS1 { get; set; }
        public string NdeS2 { get; set; }
        public string NdeS3 { get; set; }
        public string NdeS4 { get; set; }
        public string NdeS5 { get; set; }
        public string NcS1 { get; set; }
        public string NcS2 { get; set; }
        public string NcS3 { get; set; }
        public string NcS4 { get; set; }
        public string NcS5 { get; set; }
        public string NdS1 { get; set; }
        public string NdS2 { get; set; }
        public string NdS3 { get; set; }
        public string NdS4 { get; set; }
        public string NdS5 { get; set; }
        public int FactF1 { get; set; }
        public int FactF2 { get; set; }
        public int FactF3 { get; set; }
        public int FactF4 { get; set; }
        public int NdeF1 { get; set; }
        public int NdeF2 { get; set; }
        public int NdeF3 { get; set; }
        public int NdeF4 { get; set; }
        public int NcF1 { get; set; }
        public int NcF2 { get; set; }
        public int NcF3 { get; set; }
        public int NcF4 { get; set; }
        public int NdF1 { get; set; }
        public int NdF2 { get; set; }
        public int NdF3 { get; set; }
        public int NdF4 { get; set; }
        public int FactP1 { get; set; }
        public int FactP2 { get; set; }
        public int FactP3 { get; set; }
        public int FactP4 { get; set; }
        public int FactP5 { get; set; }
        public int NdeP1 { get; set; }
        public int NdeP2 { get; set; }
        public int NdeP3 { get; set; }
        public int NdeP4 { get; set; }
        public int NdeP5 { get; set; }
        public int NcP1 { get; set; }
        public int NcP2 { get; set; }
        public int NcP3 { get; set; }
        public int NcP4 { get; set; }
        public int NcP5 { get; set; }
        public int NdP1 { get; set; }
        public int NdP2 { get; set; }
        public int NdP3 { get; set; }
        public int NdP4 { get; set; }
        public int NdP5 { get; set; }
        public int FactNum2 { get; set; }
        public int FactNum3 { get; set; }
        public int FactNum4 { get; set; }
        public int FactNum5 { get; set; }
        public int NdeNum2 { get; set; }
        public int NdeNum3 { get; set; }
        public int NdeNum4 { get; set; }
        public int NdeNum5 { get; set; }
        public int NcNum2 { get; set; }
        public int NcNum3 { get; set; }
        public int NcNum4 { get; set; }
        public int NcNum5 { get; set; }
        public int NdNum2 { get; set; }
        public int NdNum3 { get; set; }
        public int NdNum4 { get; set; }
        public int NdNum5 { get; set; }
        public bool Serie2 { get; set; }
        public bool Serie3 { get; set; }
        public bool Serie4 { get; set; }
        public bool Serie5 { get; set; }
        public int EmpNum { get; set; }
        public int DmcNum { get; set; }
        public int TaxNum { get; set; }
        public int CedNum { get; set; }
        public int EntNum { get; set; }
        public int CieNum { get; set; }
        public int OdpNum { get; set; }
        public int ReqNum { get; set; }
        public int DevNum { get; set; }
        public int ExpNum { get; set; }
        public int InpNum { get; set; }
        public int CostNum { get; set; }
        public int ParNum { get; set; }
        public int EscNum { get; set; }
        public int PlaNum { get; set; }
        public int MenNum { get; set; }
        public int DistNum { get; set; }
        public int ExpNumi { get; set; }

        public virtual ICollection<Ajuste> Ajuste { get; set; }
        public virtual ICollection<Ambtras> Ambtras { get; set; }
        public virtual ICollection<Cobros> Cobros { get; set; }
        public virtual ICollection<Compras> Compras { get; set; }
        public virtual ICollection<CotizC> CotizC { get; set; }
        public virtual ICollection<DepCaj> DepCaj { get; set; }
        public virtual ICollection<DevCli> DevCli { get; set; }
        public virtual ICollection<DevPro> DevPro { get; set; }
        public virtual ICollection<DocumCc> DocumCc { get; set; }
        public virtual ICollection<DocumCp> DocumCp { get; set; }
        public virtual ICollection<Factura> Factura { get; set; }
        public virtual ICollection<Fisico> Fisico { get; set; }
        public virtual ICollection<ImpMun> ImpMun { get; set; }
        public virtual ICollection<NotDep> NotDep { get; set; }
        public virtual ICollection<NotEnt> NotEnt { get; set; }
        public virtual ICollection<NotRec> NotRec { get; set; }
        public virtual ICollection<OrdPago> OrdPago { get; set; }
        public virtual ICollection<Ordenes> Ordenes { get; set; }
        public virtual ICollection<Pagos> Pagos { get; set; }
        public virtual ICollection<Pedidos> Pedidos { get; set; }
        public virtual ICollection<Plavent> Plavent { get; set; }
        public virtual ICollection<Rentab> Rentab { get; set; }
        public virtual ICollection<SubAlma> SubAlma { get; set; }
        public virtual ICollection<Turnosic> TurnosicNavigation { get; set; }
    }
}
