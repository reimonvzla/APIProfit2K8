namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Entidades;
    using Microsoft.EntityFrameworkCore;
    using Models;

    public class ProveedoresRespositorio : IRepositorio<Prov>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        
        #region Find
        public Prov Find(int key, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetProveedor
        public Prov GetProveedor(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Prov.FirstOrDefault(p => p.CoProv.Trim() == key.Trim());
        }
        #endregion

        #region GetAll
        public IEnumerable<Prov> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.Prov.ToList();
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(Prov item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                
                ValidarProveedor(item, empresaDB, true);
                
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
        public Response Update(Prov item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                var rowID = GetProveedor(item.CoProv.Trim(), empresaDB);

                if (rowID == null)
                {
                    throw new ArgumentException($"El proveedor {item.CoProv.Trim()} no existe.");
                }

                ValidarProveedor(item, empresaDB, false);

                item.Rowguid = rowID.Rowguid;

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

        #region Validar proveedor
        private void ValidarProveedor(Prov obj, string empresaDB, bool isGuardar)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            Prov proveedor = db.Prov.FirstOrDefault(p => p.CoProv.Trim() == obj.CoProv.Trim());

            if (proveedor == null || !isGuardar)
            {
                #region Tipo proveedor
                TipoPro tipoPro = db.TipoPro.FirstOrDefault(tp => tp.TipPro.Trim() == obj.Tipo.Trim());
                if (tipoPro == null) throw new ArgumentException($"El tipo de proveedor [{obj.Tipo.Trim()}] indicado no existe.");
                #endregion

                #region Zona
                Zona zona = db.Zona.FirstOrDefault(z => z.CoZon.Trim() == obj.CoZon.Trim());
                if (zona == null) throw new ArgumentException($"La zona {obj.CoZon.Trim()} indicada no existe.");
                #endregion

                #region Segmento
                Segmento segmento = db.Segmento.FirstOrDefault(s => s.CoSeg.Trim() == obj.CoSeg.Trim());
                if (segmento == null) throw new ArgumentException($"El segmento {obj.CoSeg.Trim()} indicado no existe.");
                #endregion

                #region Cuenta ingr/egre
                CtaIngr ctaIngr = db.CtaIngr.FirstOrDefault(f => f.CoIngr.Trim() == obj.CoIngr.Trim());
                if (ctaIngr == null) throw new ArgumentException($"La cuenta ingreso/egreso {obj.CoIngr.Trim()} indicada no existe.");
                #endregion

                #region Sucursal
                Utilitarios utilitarios = new Utilitarios();
                utilitarios.GetSucursal(obj.CoSucu, empresaDB);
                #endregion

                #region Tabulador ISLR
                TabIslr tabulador = db.TabIslr.FirstOrDefault(t => t.CoTab == obj.CoTab);
                if (tabulador == null) throw new ArgumentException($"El tabulador de ISLR {obj.CoTab} indicado no existe.");
                #endregion
            }
            else
            {
                throw new ArgumentException($"El Proveedor {obj.CoProv.Trim()} indicado ya existe.");
            }
        } 
        #endregion
    }
}
