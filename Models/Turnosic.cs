using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Turnosic
    {
        public string CoTurno { get; set; }
        public string CodCaja { get; set; }
        public double Saldo { get; set; }
        public int NumTurno { get; set; }
        public string UserCaj { get; set; }
        public string UserSup { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Finaliza { get; set; }
        public decimal Status { get; set; }
        public bool Restringe { get; set; }
        public decimal HoraIni { get; set; }
        public decimal MinuIni { get; set; }
        public string AmpmIni { get; set; }
        public decimal HoraFin { get; set; }
        public decimal MinuFin { get; set; }
        public string AmpmFin { get; set; }
        public string CoUsIn { get; set; }
        public DateTime FeUsIn { get; set; }
        public string CoUsMo { get; set; }
        public DateTime FeUsMo { get; set; }
        public string CoUsEl { get; set; }
        public DateTime FeUsEl { get; set; }
        public string Revisado { get; set; }
        public string Trasnfe { get; set; }
        public string CoSucu { get; set; }
        public bool PtoVta { get; set; }
        public Guid Rowguid { get; set; }

        public virtual Almacen CoSucuNavigation { get; set; }
        public virtual Turnos CoTurnoNavigation { get; set; }
    }
}
