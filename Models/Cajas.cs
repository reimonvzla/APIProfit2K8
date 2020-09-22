using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Cajas
    {
        public Cajas()
        {
            MovCaj = new HashSet<MovCaj>();
            RengDp = new HashSet<RengDp>();
        }

        public string CodCaja { get; set; }
        public string Descrip { get; set; }
        public DateTime MesIni { get; set; }
        public decimal SaldoI { get; set; }
        public decimal SaldoEi { get; set; }
        public decimal SaldoA { get; set; }
        public decimal SaldoE { get; set; }
        public string Moneda { get; set; }
        public string Campo1 { get; set; }
        public string Campo2 { get; set; }
        public string Campo3 { get; set; }
        public string Campo4 { get; set; }
        public string DisCen { get; set; }
        public decimal DebAnt { get; set; }
        public decimal HabAnt { get; set; }
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
        public bool Gavetaser { get; set; }
        public bool Cajapri { get; set; }
        public bool Sidisplay { get; set; }
        public string Puerto { get; set; }
        public string Bitdatos { get; set; }
        public string Bitstop { get; set; }
        public string Paridad { get; set; }
        public string Velocidad { get; set; }
        public string Puerto2 { get; set; }
        public string Bitdatos2 { get; set; }
        public string Bitstop2 { get; set; }
        public string Paridad2 { get; set; }
        public string Gcadena { get; set; }
        public string Velocidad2 { get; set; }
        public bool Cajapvta { get; set; }
        public bool Mvisa { get; set; }
        public int Vpostipo { get; set; }
        public string Impfis { get; set; }

        public virtual ICollection<MovCaj> MovCaj { get; set; }
        public virtual ICollection<RengDp> RengDp { get; set; }
    }
}
