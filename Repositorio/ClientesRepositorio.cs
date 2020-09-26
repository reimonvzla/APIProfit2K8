namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class ClientesRepositorio:IRepositorio<Clientes>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public Clientes Find(int key, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region GetAll
        public IEnumerable<Clientes> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Clientes.ToList();
        } 
        #endregion

        #region GetCliente
        public Clientes GetCliente(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Clientes.FirstOrDefault(c => c.CoCli.Trim() == key);
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region Save
        public Response Save(Clientes item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                #region Validar datos cliente
                ValidarCliente(item, empresaDB, true); 
                #endregion

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

        #region Validar cliente
        private void ValidarCliente(Clientes obj,string empresaDB,bool isGuardar)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            Clientes cliente = db.Clientes.FirstOrDefault(c => c.CoCli == obj.CoCli);
            
            /*El parametro isGuardar se estable para validar registros inclusive editando*/

            if (cliente == null || !isGuardar)
            {
                #region Tipo cliente
                TipoCli tipo = db.TipoCli.FirstOrDefault(t => t.TipCli.Trim() == obj.Tipo.Trim());
                if (tipo == null) throw new ArgumentException($"El tipo de cliente {obj.Tipo.Trim()} indicado no existe.");
                #endregion

                #region Zona
                Zona zona = db.Zona.FirstOrDefault(z => z.CoZon.Trim() == obj.CoZon.Trim());
                if (zona == null)
                {
                    throw new ArgumentException($"La zona {obj.CoZon.Trim()} indicada no existe.");
                } 
                #endregion

                #region Segmento
                Segmento segmento = db.Segmento.FirstOrDefault(s => s.CoSeg.Trim() == obj.CoSeg.Trim());
                if (segmento == null)
                {
                    throw new ArgumentException($"El segmento {obj.CoSeg.Trim()} indicado no existe.");
                } 
                #endregion

                #region Vendedor
                Vendedor vendedor = db.Vendedor.FirstOrDefault(v => v.CoVen.Trim() == obj.CoVen.Trim());
                if (vendedor == null)
                {
                    throw new ArgumentException($"El vendedor {obj.CoVen.Trim()} indicado no existe.");
                } 
                #endregion

                #region Cuenta ingr/egre
                CtaIngr ctaIngr = db.CtaIngr.FirstOrDefault(f => f.CoIngr.Trim() == obj.CoIngr.Trim());
                if (ctaIngr == null)
                {
                    throw new ArgumentException($"La cuenta ingreso/egreso {obj.CoIngr.Trim()} indicada no existe.");
                }
                #endregion

                #region Sucursal
                Utilitarios utilitarios = new Utilitarios();
                utilitarios.GetSucursal(obj.CoSucu, empresaDB);
                #endregion

                #region Tabulador ISLR
                TabIslr tabulador = db.TabIslr.FirstOrDefault(t => t.CoTab == obj.CoTab);
                if (tabulador == null)
                {
                    throw new ArgumentException($"El tabulador de ISLR {obj.CoTab} indicado no existe.");
                } 
                #endregion
            }
            else 
            {
                throw new ArgumentException($"El cliente {obj.CoCli.Trim()} indicado ya existe.");
            }
        }
        #endregion

        #region Update
        public Response Update(Clientes item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                var rowID = GetCliente(item.CoCli.Trim(), empresaDB);
                
                if (rowID == null)
                {
                    throw new ArgumentException($"El cliente {item.CoCli.Trim()} no existe.");
                }

                ValidarCliente(item, empresaDB, false);

                item.CoUsMo = "999";
                item.FeUsMo = DateTime.Now;
                item.RowId = rowID.RowId;
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
