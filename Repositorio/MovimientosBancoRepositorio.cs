namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Entidades;
    using Models;

    public class MovimientosBancoRepositorio : IRepositorio<MovBan>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public MovBan Find(int key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.MovBan.FirstOrDefault(mb => mb.MovNum == key);
        } 
        #endregion

        #region Obtiene el movimiento de banco segun el documento y el origen ('COBRO' o 'PAGO') y la operacion sea deposito
        public MovBan GetMovBanxDoc(string key, string origen, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.MovBan.FirstOrDefault(mb => mb.DocNum == key && mb.Origen == origen && mb.TipoOp == "DP" && mb.Anulado == false);
        } 
        #endregion

        public IEnumerable<MovBan> GetAll(string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(MovBan item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(MovBan item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
