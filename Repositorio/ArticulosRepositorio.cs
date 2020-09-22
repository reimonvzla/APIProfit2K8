namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class ArticulosRepositorio
    {
        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public Art Find(string key, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                var Qry= db.Art.FirstOrDefault(a => a.CoArt == key);
                return db.Art.FirstOrDefault(a => a.CoArt == key);
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }
        }
        #endregion

        #region GetAll
        public ICollection<Art> GetAll(string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                return db.Art.ToList();
            }
            catch (Exception ex)
            {
                throw new ArgumentException(ex.Message);
            }

        }
        #endregion

        #region Save
        public Response Save(Art item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                ValidarArticulo(item, empresaDB, true);

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
        public Response Update(Art item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                var rowID = Find(item.CoArt, empresaDB);
                if (rowID == null)
                {
                    throw new ArgumentException($"El artículo {item.CoArt.Trim()} no existe.");
                }

                ValidarArticulo(item, empresaDB, false);

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

        #region Validar articulo
        private void ValidarArticulo(Art obj, string empresaDB, bool isGuardar)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            Art articulo = db.Art.FirstOrDefault(a => a.CoArt == obj.CoArt.Trim());

            /*El parametro isGuardar se estable para validar registros inclusive editando*/

            if (articulo == null || !isGuardar)
            {

                #region Verificar linea
                LinArt linea = db.LinArt.FirstOrDefault(l => l.CoLin == obj.CoLin.Trim());
                if (linea == null)
                {
                    throw new ArgumentException($"La línea {obj.CoLin.Trim()} indicada no existe.");
                }
                #endregion

                #region Verificar sublinea
                SubLin sublinea = db.SubLin.FirstOrDefault(sl => sl.CoSubl == obj.CoSubl.Trim() && sl.CoLin == obj.CoLin.Trim());
                if (sublinea == null)
                {
                    throw new ArgumentException($"La Sublínea {obj.CoSubl.Trim()} indicada no existe ó no pertenece a la línea {obj.CoLin.Trim()} verifique.");
                }
                #endregion

                #region Varificar catergoria
                CatArt categoria = db.CatArt.FirstOrDefault(c => c.CoCat == obj.CoCat.Trim());
                if (categoria == null)
                {
                    throw new ArgumentException($"La categoría {obj.CoCat.Trim()} indicada no existe.");
                }
                #endregion

                #region Verificar color
                Colores color = db.Colores.FirstOrDefault(c => c.CoCol == obj.CoColor.Trim());
                if (color == null)
                {
                    throw new ArgumentException($"El coloro {obj.CoColor.Trim()} indicado no existe.");
                }
                #endregion

                #region Verificar procedencia
                Proceden procedencia = db.Proceden.FirstOrDefault(p => p.CodProc == obj.Procedenci.Trim());
                if (procedencia == null)
                {
                    throw new ArgumentException($"La procedencia {obj.Procedenci.Trim()} indicada no existe.");
                }
                #endregion

                #region Verificar proveedor
                Prov proveedor = db.Prov.FirstOrDefault(p => p.CoProv == obj.CoProv.Trim());
                if (proveedor == null)
                {
                    throw new ArgumentException($"El proveedor {obj.CoProv.Trim()} indicado no existe.");
                }
                #endregion

                #region VErificar unidad primaria
                Unidades unidad = db.Unidades.FirstOrDefault(u => u.CoUni == obj.UniVenta.Trim());
                if (unidad == null)
                {
                    throw new ArgumentException($"La unidad primaria {obj.UniVenta.Trim()} indicada no existe.");
                }
                #endregion

                #region Verificar sucursal
                Almacen susursal = db.Almacen.FirstOrDefault(s => s.CoAlma == obj.CoSucu.Trim());
                if (susursal == null)
                {
                    throw new ArgumentException($"La sucursal {obj.CoSucu.Trim()} indicada no existe.");
                }
                #endregion

            }
            else
            {
                throw new ArgumentException($"El artículo {obj.CoArt.Trim()} indicado ya existe.");
            }

        }
        #endregion
    }
}