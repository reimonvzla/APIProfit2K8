namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
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
            return db.MovBan.FirstOrDefault(mb => mb.DocNum.Trim() == key && mb.Origen.Trim() == origen && mb.TipoOp == "DP" && mb.Anulado == false);
        }
        #endregion

        #region GetAll
        public IEnumerable<MovBan> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.MovBan.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(MovBan item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                db.Entry(item).State = EntityState.Added;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Movimiento de banco creado satisfactoriamente" };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(MovBan item, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion
    
    }
}
