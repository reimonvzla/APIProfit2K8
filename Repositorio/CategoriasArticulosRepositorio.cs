namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class CategoriasArticulosRepositorio
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        
        #region Find
        public CatArt Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.CatArt.FirstOrDefault(c => c.CoCat.Trim() == key.Trim());
        } 
        #endregion

        #region GetAll
        public ICollection<CatArt> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.CatArt.ToList();
        } 
        #endregion

        #region Save
        public Response Save(CatArt item, string empresaDB)
        {
            try
            {
                CatArt categoria = Find(item.CoCat, empresaDB);
                if (categoria != null) throw new ArgumentException($"La categoría {item.CoCat.Trim()} ya existe.");

                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                item.Rowguid = Guid.NewGuid();
                db.Entry(item).State = EntityState.Added;
                return new Response { Status = "OK", Message = "Transacción realizada con éxito." };

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

        #region Update
        public Response Update(CatArt item, string empresaDB)
        {
            try
            {
                CatArt categoria = Find(item.CoCat, empresaDB);
                if (categoria == null) throw new ArgumentException($"La categoría {item.CoCat.Trim()} no existe.");
                
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                item.Rowguid = categoria.Rowguid;
                db.Entry(item).State = EntityState.Modified;
                return new Response { Status = "OK", Message = "Transacción realizada con éxito." };

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion
    }
}
