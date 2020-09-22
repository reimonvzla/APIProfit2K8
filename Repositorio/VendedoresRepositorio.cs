namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;


    public class VendedoresRepositorio 
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public Vendedor Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Vendedor.FirstOrDefault(v => v.CoVen == key);
        } 
        #endregion

        public IEnumerable<Vendedor> GetAll(string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(Vendedor item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(Vendedor item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
