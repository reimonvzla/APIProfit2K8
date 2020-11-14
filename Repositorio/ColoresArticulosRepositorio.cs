namespace APIProfit2K8.Repositorio
{
    using APIProfit2K8.Entidades;
    using APIProfit2K8.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;

    public class ColoresArticulosRepositorio
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        
        #region Find
        public Colores Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Colores.FirstOrDefault(c => c.CoCol.Trim() == key.Trim());
        } 
        #endregion

        #region GetAll
        public ICollection<Colores> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Colores.ToList();
        } 
        #endregion

        #region Save
        public Response Save(Colores item, string empresaDB)
        {
            try
            {
                Colores color = Find(item.CoCol, empresaDB);
                if (color != null) throw new ArgumentException($"El color {item.CoCol.Trim()} ya existe.");

                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                item.Rowguid = Guid.NewGuid();
                db.Entry(item).State = EntityState.Added;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Transacción realizada con éxito." };

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

        #region Update
        public Response Update(Colores item, string empresaDB)
        {
            try
            {
                Colores color = Find(item.CoCol, empresaDB);
                if (color == null) throw new ArgumentException($"El color {item.CoCol.Trim()} no existe.");

                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                item.Rowguid = color.Rowguid;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Actualización realizada con éxito." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

    }
}
