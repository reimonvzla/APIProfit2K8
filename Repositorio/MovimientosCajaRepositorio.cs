namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Models;

    public class MovimientosCajaRepositorio : IRepositorio<MovCaj>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        public MovCaj Find(int key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.MovCaj.FirstOrDefault(mc => mc.MovNum == key);
        }

        public IEnumerable<MovCaj> GetAll(string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(MovCaj item, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Update(MovCaj item, string empresaDB)
        {
            throw new NotImplementedException();
        }
    }
}
