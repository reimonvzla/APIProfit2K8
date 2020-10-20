namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class MovimientosCajaRepositorio : IRepositorio<MovCaj>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public MovCaj Find(int key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.MovCaj.FirstOrDefault(mc => mc.MovNum == key);
        }
        #endregion

        #region GetAll
        public IEnumerable<MovCaj> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.MovCaj.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(MovCaj item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                db.Entry(item).State = EntityState.Added;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Movimiento de caja guardado con éxito" };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

        #region Update
        public Response Update(MovCaj item, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            db.Entry(item).State = EntityState.Modified;
            db.SaveChanges();
            return new Response { Status = "OK", Message = "Movimiento de caja actualizado con éxito" };
        } 
        #endregion
    }
}
