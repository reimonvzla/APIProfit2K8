using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Turnos
    {
        public Turnos()
        {
            Turnosic = new HashSet<Turnosic>();
        }

        public string CoTurno { get; set; }
        public string DesTurno { get; set; }
        public decimal HoraIni { get; set; }
        public decimal MinuIni { get; set; }
        public string AmpmIni { get; set; }
        public decimal HoraFin { get; set; }
        public decimal MinuFin { get; set; }
        public string AmpmFin { get; set; }
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

        public virtual ICollection<Turnosic> Turnosic { get; set; }
    }
}
