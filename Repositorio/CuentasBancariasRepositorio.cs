namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class CuentasBancariasRepositorio : IRepositorio<Cuentas>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public Cuentas Find(int key, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region GetCuenta
        public Cuentas GetCuenta(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Cuentas.FirstOrDefault(c => c.CodCta.Trim() == key);
        }
        #endregion

        #region GetAll
        public IEnumerable<Cuentas> GetAll(string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(Cuentas item, string empresaDB)
        {
            try
            {
                Cuentas cuenta = GetCuenta(item.CodCta, empresaDB);

                if (cuenta != null) throw new ArgumentException($"La cuenta bancaria {item.CodCta.Trim()} ya existe.");

                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                item.Rowguid = Guid.NewGuid();
                db.Entry(item).State = EntityState.Added;
                db.SaveChanges();
                return new Response { Status = "OK", Message = "Cuenta bancaria registrada con éxito" };

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(Cuentas item, string empresaDB)
        {
            try
            {
                Cuentas cuenta = GetCuenta(item.CodCta, empresaDB);
                if (cuenta == null) throw new ArgumentException($"La cuenta bancaria {item.CodCta.Trim()} no existe.");

                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                item.Rowguid = cuenta.Rowguid;
                item.RowId = cuenta.RowId;
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = $"Cuenta bancaria {item.CodCta.Trim()} actualizada con éxito" };

            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }

        } 
        #endregion
    
    }
}
