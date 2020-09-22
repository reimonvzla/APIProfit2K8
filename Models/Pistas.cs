using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class Pistas
    {
        public string UsuarioId { get; set; }
        public string Usuario { get; set; }
        public DateTime Fecha { get; set; }
        public string Empresa { get; set; }
        public string CoSucu { get; set; }
        public string Tabla { get; set; }
        public int NumDoc { get; set; }
        public string Codigo { get; set; }
        public string TipoOp { get; set; }
        public string Maquina { get; set; }
        public string Campos { get; set; }
        public Guid Rowguid { get; set; }
        public string Trasnfe { get; set; }
        public decimal Aux01 { get; set; }
        public string Aux02 { get; set; }
    }
}
