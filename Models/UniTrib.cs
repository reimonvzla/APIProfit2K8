using System;
using System.Collections.Generic;

namespace APIProfit2K8.Models
{
    public partial class UniTrib
    {
        public string UniGact { get; set; }
        public DateTime UniFec { get; set; }
        public DateTime UniFecp { get; set; }
        public decimal Valor { get; set; }
        public Guid Rowguid { get; set; }
    }
}
