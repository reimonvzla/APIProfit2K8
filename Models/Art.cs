using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Art
    {
        public Art()
        {
            CostImp = new HashSet<CostImp>();
            GeneKit = new HashSet<GeneKit>();
            Kit = new HashSet<Kit>();
            LoteNavigation = new HashSet<Lote>();
            RengAce = new HashSet<RengAce>();
            RengAco = new HashSet<RengAco>();
            RengAim = new HashSet<RengAim>();
            RengAju = new HashSet<RengAju>();
            RengAra = new HashSet<RengAra>();
            RengArt = new HashSet<RengArt>();
            RengCac = new HashSet<RengCac>();
            RengCdp = new HashSet<RengCdp>();
            RengCie = new HashSet<RengCie>();
            RengCom = new HashSet<RengCom>();
            RengDcc = new HashSet<RengDcc>();
            RengDcp = new HashSet<RengDcp>();
            RengDvc = new HashSet<RengDvc>();
            RengDvp = new HashSet<RengDvp>();
            RengEnc = new HashSet<RengEnc>();
            RengEnp = new HashSet<RengEnp>();
            RengEnt = new HashSet<RengEnt>();
            RengFac = new HashSet<RengFac>();
            RengFis = new HashSet<RengFis>();
            RengGen = new HashSet<RengGen>();
            RengKit = new HashSet<RengKit>();
            RengNdd = new HashSet<RengNdd>();
            RengNde = new HashSet<RengNde>();
            RengNdr = new HashSet<RengNdr>();
            RengOdp = new HashSet<RengOdp>();
            RengOrd = new HashSet<RengOrd>();
            RengPed = new HashSet<RengPed>();
            RengPlc = new HashSet<RengPlc>();
            RengPlv = new HashSet<RengPlv>();
            RengRes = new HashSet<RengRes>();
            RengRmc = new HashSet<RengRmc>();
            RengRmp = new HashSet<RengRmp>();
            RengTra = new HashSet<RengTra>();
            Spced = new HashSet<Spced>();
            StAlmac = new HashSet<StAlmac>();
            StLote = new HashSet<StLote>();
        }

        public string CoArt { get; set; }
        public string ArtDes { get; set; }
        public DateTime FechaReg { get; set; }
        public bool ManjSer { get; set; }
        public string CoLin { get; set; }
        public string CoCat { get; set; }
        public string CoSubl { get; set; }
        public string CoColor { get; set; }
        public string Item { get; set; }
        public string Ref { get; set; }
        public string Modelo { get; set; }
        public string Procedenci { get; set; }
        public string Comentario { get; set; }
        public string CoProv { get; set; }
        public string Ubicacion { get; set; }
        public string UniVenta { get; set; }
        public string UniCompra { get; set; }
        public decimal UniRelac { get; set; }
        public int RelacAut { get; set; }
        public decimal StockAct { get; set; }
        public decimal StockCom { get; set; }
        public decimal SstockCom { get; set; }
        public decimal StockLle { get; set; }
        public decimal SstockLle { get; set; }
        public decimal StockDes { get; set; }
        public decimal SstockDes { get; set; }
        public string SuniVenta { get; set; }
        public string SuniCompr { get; set; }
        public decimal SuniRelac { get; set; }
        public decimal SstockAct { get; set; }
        public decimal RelacComp { get; set; }
        public decimal RelacVent { get; set; }
        public decimal PtoPedido { get; set; }
        public decimal StockMax { get; set; }
        public decimal StockMin { get; set; }
        public bool PrecOm { get; set; }
        public decimal PrecVta1 { get; set; }
        public DateTime FecPrecV { get; set; }
        public DateTime FecPrec2 { get; set; }
        public decimal PrecVta2 { get; set; }
        public DateTime FecPrec3 { get; set; }
        public decimal PrecVta3 { get; set; }
        public DateTime FecPrec4 { get; set; }
        public decimal PrecVta4 { get; set; }
        public DateTime FecPrec5 { get; set; }
        public decimal PrecVta5 { get; set; }
        public decimal PrecAgr1 { get; set; }
        public decimal PrecAgr2 { get; set; }
        public decimal PrecAgr3 { get; set; }
        public decimal PrecAgr4 { get; set; }
        public decimal PrecAgr5 { get; set; }
        public decimal CanAgr { get; set; }
        public DateTime FecDesP5 { get; set; }
        public DateTime FecHasP5 { get; set; }
        public string CoImp { get; set; }
        public decimal MargenMax { get; set; }
        public decimal UltCosUn { get; set; }
        public DateTime FecUltCo { get; set; }
        public decimal CosProUn { get; set; }
        public DateTime FecCosPr { get; set; }
        public decimal CosMerc { get; set; }
        public DateTime FecCosMe { get; set; }
        public decimal CosProv { get; set; }
        public DateTime FecCosP2 { get; set; }
        public decimal UltCosDo { get; set; }
        public DateTime FecCosDo { get; set; }
        public decimal CosUnAn { get; set; }
        public DateTime FecCosAn { get; set; }
        public decimal UltCosOm { get; set; }
        public DateTime FecUltOm { get; set; }
        public decimal CosProOm { get; set; }
        public DateTime FecProOm { get; set; }
        public string TipoCos { get; set; }
        public decimal MontComi { get; set; }
        public decimal PorcCos { get; set; }
        public decimal MontCos { get; set; }
        public decimal PorcGas { get; set; }
        public decimal MontGas { get; set; }
        public DateTime FCost { get; set; }
        public bool Fisico { get; set; }
        public decimal PuntCli { get; set; }
        public decimal PuntPro { get; set; }
        public int DiasRepos { get; set; }
        public string Tipo { get; set; }
        public string AlmPrin { get; set; }
        public bool Anulado { get; set; }
        public string TipoImp { get; set; }
        public string DisCen { get; set; }
        public decimal MonIlc { get; set; }
        public decimal Capacidad { get; set; }
        public decimal GradoAl { get; set; }
        public string TipoLicor { get; set; }
        public bool Compuesto { get; set; }
        public byte[] Picture { get; set; }
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
        public string TuniVenta { get; set; }
        public decimal EquiUni1 { get; set; }
        public decimal EquiUni2 { get; set; }
        public decimal EquiUni3 { get; set; }
        public bool Lote { get; set; }
        public string Serialp { get; set; }
        public bool Valido { get; set; }
        public bool Atributo1 { get; set; }
        public string Vatributo1 { get; set; }
        public bool Atributo2 { get; set; }
        public string Vatributo2 { get; set; }
        public bool Atributo3 { get; set; }
        public string Vatributo3 { get; set; }
        public bool Atributo4 { get; set; }
        public string Vatributo4 { get; set; }
        public bool Atributo5 { get; set; }
        public string Vatributo5 { get; set; }
        public bool Atributo6 { get; set; }
        public string Vatributo6 { get; set; }
        public string Garantia { get; set; }
        public decimal Peso { get; set; }
        public decimal Pie { get; set; }
        public decimal Margen1 { get; set; }
        public decimal Margen2 { get; set; }
        public decimal Margen3 { get; set; }
        public decimal Margen4 { get; set; }
        public decimal Margen5 { get; set; }
        public byte[] RowId { get; set; }
        public string Imagen1 { get; set; }
        public string Imagen2 { get; set; }
        public string IArtDes { get; set; }
        public string UniEmp { get; set; }
        public decimal RelEmp { get; set; }
        public bool Movil { get; set; }

        public virtual SubLin Co { get; set; }
        public virtual CatArt CoCatNavigation { get; set; }
        public virtual Colores CoColorNavigation { get; set; }
        public virtual LinArt CoLinNavigation { get; set; }
        public virtual Prov CoProvNavigation { get; set; }
        public virtual Proceden ProcedenciNavigation { get; set; }
        public virtual Unidades SuniVentaNavigation { get; set; }
        public virtual Tabulado TipoImpNavigation { get; set; }
        public virtual Unidades UniVentaNavigation { get; set; }
        public virtual Aranc Aranc { get; set; }
        public virtual ArtExt ArtExt { get; set; }
        public virtual ICollection<CostImp> CostImp { get; set; }
        public virtual ICollection<GeneKit> GeneKit { get; set; }
        public virtual ICollection<Kit> Kit { get; set; }
        public virtual ICollection<Lote> LoteNavigation { get; set; }
        public virtual ICollection<RengAce> RengAce { get; set; }
        public virtual ICollection<RengAco> RengAco { get; set; }
        public virtual ICollection<RengAim> RengAim { get; set; }
        public virtual ICollection<RengAju> RengAju { get; set; }
        public virtual ICollection<RengAra> RengAra { get; set; }
        public virtual ICollection<RengArt> RengArt { get; set; }
        public virtual ICollection<RengCac> RengCac { get; set; }
        public virtual ICollection<RengCdp> RengCdp { get; set; }
        public virtual ICollection<RengCie> RengCie { get; set; }
        public virtual ICollection<RengCom> RengCom { get; set; }
        public virtual ICollection<RengDcc> RengDcc { get; set; }
        public virtual ICollection<RengDcp> RengDcp { get; set; }
        public virtual ICollection<RengDvc> RengDvc { get; set; }
        public virtual ICollection<RengDvp> RengDvp { get; set; }
        public virtual ICollection<RengEnc> RengEnc { get; set; }
        public virtual ICollection<RengEnp> RengEnp { get; set; }
        public virtual ICollection<RengEnt> RengEnt { get; set; }
        public virtual ICollection<RengFac> RengFac { get; set; }
        public virtual ICollection<RengFis> RengFis { get; set; }
        public virtual ICollection<RengGen> RengGen { get; set; }
        public virtual ICollection<RengKit> RengKit { get; set; }
        public virtual ICollection<RengNdd> RengNdd { get; set; }
        public virtual ICollection<RengNde> RengNde { get; set; }
        public virtual ICollection<RengNdr> RengNdr { get; set; }
        public virtual ICollection<RengOdp> RengOdp { get; set; }
        public virtual ICollection<RengOrd> RengOrd { get; set; }
        public virtual ICollection<RengPed> RengPed { get; set; }
        public virtual ICollection<RengPlc> RengPlc { get; set; }
        public virtual ICollection<RengPlv> RengPlv { get; set; }
        public virtual ICollection<RengRes> RengRes { get; set; }
        public virtual ICollection<RengRmc> RengRmc { get; set; }
        public virtual ICollection<RengRmp> RengRmp { get; set; }
        public virtual ICollection<RengTra> RengTra { get; set; }
        public virtual ICollection<Spced> Spced { get; set; }
        public virtual ICollection<StAlmac> StAlmac { get; set; }
        public virtual ICollection<StLote> StLote { get; set; }
    }
}
