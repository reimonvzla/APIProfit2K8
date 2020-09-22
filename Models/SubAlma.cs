using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class SubAlma
    {
        public SubAlma()
        {
            Fisico = new HashSet<Fisico>();
            GeneKit = new HashSet<GeneKit>();
            RengAju = new HashSet<RengAju>();
            RengCac = new HashSet<RengCac>();
            RengCdp = new HashSet<RengCdp>();
            RengCom = new HashSet<RengCom>();
            RengDvc = new HashSet<RengDvc>();
            RengDvp = new HashSet<RengDvp>();
            RengEnc = new HashSet<RengEnc>();
            RengEnp = new HashSet<RengEnp>();
            RengFac = new HashSet<RengFac>();
            RengGen = new HashSet<RengGen>();
            RengNdd = new HashSet<RengNdd>();
            RengNde = new HashSet<RengNde>();
            RengNdr = new HashSet<RengNdr>();
            RengOrd = new HashSet<RengOrd>();
            RengPed = new HashSet<RengPed>();
            RengPlc = new HashSet<RengPlc>();
            RengPlv = new HashSet<RengPlv>();
            RengRes = new HashSet<RengRes>();
            RengRmc = new HashSet<RengRmc>();
            RengRmp = new HashSet<RengRmp>();
            Spcierre = new HashSet<Spcierre>();
            Spentre = new HashSet<Spentre>();
            StAlmac = new HashSet<StAlmac>();
            StLote = new HashSet<StLote>();
            TrasAlmAlmDestNavigation = new HashSet<TrasAlm>();
            TrasAlmAlmOrigNavigation = new HashSet<TrasAlm>();
        }

        public string CoSub { get; set; }
        public string DesSub { get; set; }
        public string CoAlma { get; set; }
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
        public bool Noventa { get; set; }
        public bool Nocompra { get; set; }
        public bool Materiales { get; set; }
        public bool Produccion { get; set; }

        public virtual Almacen CoAlmaNavigation { get; set; }
        public virtual ICollection<Fisico> Fisico { get; set; }
        public virtual ICollection<GeneKit> GeneKit { get; set; }
        public virtual ICollection<RengAju> RengAju { get; set; }
        public virtual ICollection<RengCac> RengCac { get; set; }
        public virtual ICollection<RengCdp> RengCdp { get; set; }
        public virtual ICollection<RengCom> RengCom { get; set; }
        public virtual ICollection<RengDvc> RengDvc { get; set; }
        public virtual ICollection<RengDvp> RengDvp { get; set; }
        public virtual ICollection<RengEnc> RengEnc { get; set; }
        public virtual ICollection<RengEnp> RengEnp { get; set; }
        public virtual ICollection<RengFac> RengFac { get; set; }
        public virtual ICollection<RengGen> RengGen { get; set; }
        public virtual ICollection<RengNdd> RengNdd { get; set; }
        public virtual ICollection<RengNde> RengNde { get; set; }
        public virtual ICollection<RengNdr> RengNdr { get; set; }
        public virtual ICollection<RengOrd> RengOrd { get; set; }
        public virtual ICollection<RengPed> RengPed { get; set; }
        public virtual ICollection<RengPlc> RengPlc { get; set; }
        public virtual ICollection<RengPlv> RengPlv { get; set; }
        public virtual ICollection<RengRes> RengRes { get; set; }
        public virtual ICollection<RengRmc> RengRmc { get; set; }
        public virtual ICollection<RengRmp> RengRmp { get; set; }
        public virtual ICollection<Spcierre> Spcierre { get; set; }
        public virtual ICollection<Spentre> Spentre { get; set; }
        public virtual ICollection<StAlmac> StAlmac { get; set; }
        public virtual ICollection<StLote> StLote { get; set; }
        public virtual ICollection<TrasAlm> TrasAlmAlmDestNavigation { get; set; }
        public virtual ICollection<TrasAlm> TrasAlmAlmOrigNavigation { get; set; }
    }
}
