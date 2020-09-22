using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class ParWeb
    {
        public string Id { get; set; }
        public string Url { get; set; }
        public string Usuario { get; set; }
        public string PassWord { get; set; }
        public string Db { get; set; }
        public string Server { get; set; }
        public string CoZon { get; set; }
        public string CoVen { get; set; }
        public string CoSeg { get; set; }
        public string CoIng { get; set; }
        public string CoSucur { get; set; }
        public string CoAlma { get; set; }
        public bool NewClient { get; set; }
        public bool ViewAcc { get; set; }
        public bool ViewDoc { get; set; }
        public bool IdasLogin { get; set; }
        public bool NegStock { get; set; }
        public bool SinStock { get; set; }
        public int Round { get; set; }
        public bool DesByLine { get; set; }
        public bool DesByArt { get; set; }
        public bool DesByCat { get; set; }
        public bool GobalDes { get; set; }
        public bool DeliveryAd { get; set; }
        public DateTime MaxofOrder { get; set; }
        public string Prefijo { get; set; }
        public DateTime Fecha { get; set; }
        public string Unidad { get; set; }
        public string Roundtype { get; set; }
        public int Meses { get; set; }
        public string CoTran { get; set; }
        public string FPago { get; set; }
        public string Sqluser { get; set; }
        public string Sqlpass { get; set; }
        public int Tipoaut { get; set; }
        public int Largo { get; set; }
        public bool Auto { get; set; }
        public int Horas { get; set; }
        public int Tipo { get; set; }
        public string Caja { get; set; }
        public string Visa { get; set; }
        public string Master { get; set; }
        public string Dep { get; set; }
        public string Authoriza { get; set; }
        public string WsNumber { get; set; }
        public string License { get; set; }
        public string LicenseN { get; set; }
        public string TipoCli { get; set; }
        public bool? Slog { get; set; }
    }
}
