namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class CuentasBancariasRepositorio : IRepositorio<Cuentas>
    {
        ConexionAlterna conn = new ConexionAlterna();

        public Cuentas Find(int key, string empresaDB)
        {
            throw new NotImplementedException();
        }

        #region GetCuenta
        public Cuentas GetCuenta(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Cuentas.FirstOrDefault(c => c.CodCta == key);
        } 
        #endregion

        public IEnumerable<Cuentas> GetAll(string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(Cuentas item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(Cuentas item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
