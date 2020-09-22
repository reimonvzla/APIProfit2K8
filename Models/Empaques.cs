using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Empaques
    {
        public Empaques()
        {
            RengEmp = new HashSet<RengEmp>();
        }

        public int EmpNum { get; set; }
        public DateTime Fecha { get; set; }
        public int NroOrig { get; set; }
        public string TipoDoc { get; set; }
        public string Descrip { get; set; }
        public string CoCli { get; set; }
        public string Status { get; set; }
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
        public string CoEnvio { get; set; }
        public DateTime? FeEnvio { get; set; }
        public string CoResrc { get; set; }
        public DateTime? FeResrc { get; set; }
        public string CoResem { get; set; }
        public string CoSucu { get; set; }
        public DateTime? FeEmp { get; set; }
        public Guid Rowguid { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public bool Anulada { get; set; }
        public int FactNum { get; set; }
        public bool Empr { get; set; }

        public virtual ICollection<RengEmp> RengEmp { get; set; }
    }
}
