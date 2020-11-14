namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class LineasArticulosRepositorio
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
        
        #region Find
        public LinArt Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

            var Qry = db.LinArt.Select(i => new LinArt
            {
                #region Campos
                CoLin = i.CoLin,
                LinDes = i.LinDes,
                DisCen = i.DisCen,
                Campo1 = i.Campo1,
                Campo2 = i.Campo2,
                Campo3 = i.Campo3,
                Campo4 = i.Campo4,
                CoUsIn = i.CoUsIn,
                FeUsIn = i.FeUsIn,
                CoUsMo = i.CoUsMo,
                FeUsMo = i.FeUsMo,
                CoUsEl = i.CoUsEl,
                FeUsEl = i.FeUsEl,
                Revisado = i.Revisado,
                Trasnfe = i.Trasnfe,
                CoSucu = i.CoSucu,
                Rowguid = i.Rowguid,
                CoImun = i.CoImun,
                CoReten = i.CoReten,
                ComiLin = i.ComiLin,
                ComiLin2 = i.ComiLin2,
                RowId = i.RowId,
                Va = i.Va,
                ILinDes = i.ILinDes,
                Movil = i.Movil,
                SubLin = i.SubLin,
                //Art = i.Art
                #endregion

            }).FirstOrDefault(l => l.CoLin.Trim() == key.Trim());

            return Qry;
        } 
        #endregion

        #region GetAll
        public ICollection<LinArt> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

            var Qry = db.LinArt.Select(i => new LinArt
            {
                #region Campos
                CoLin = i.CoLin,
                LinDes = i.LinDes,
                DisCen = i.DisCen,
                Campo1 = i.Campo1,
                Campo2 = i.Campo2,
                Campo3 = i.Campo3,
                Campo4 = i.Campo4,
                CoUsIn = i.CoUsIn,
                FeUsIn = i.FeUsIn,
                CoUsMo = i.CoUsMo,
                FeUsMo = i.FeUsMo,
                CoUsEl = i.CoUsEl,
                FeUsEl = i.FeUsEl,
                Revisado = i.Revisado,
                Trasnfe = i.Trasnfe,
                CoSucu = i.CoSucu,
                Rowguid = i.Rowguid,
                CoImun = i.CoImun,
                CoReten = i.CoReten,
                ComiLin = i.ComiLin,
                ComiLin2 = i.ComiLin2,
                RowId = i.RowId,
                Va = i.Va,
                ILinDes = i.ILinDes,
                Movil = i.Movil,
                SubLin = i.SubLin,
                //Art = i.Art
                #endregion

            }).ToList();

            return Qry;
        }
        #endregion

        #region Save
        public Response Save(LinArt item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                LinArt linea = Find(item.CoLin, empresaDB);
                if (linea != null) throw new ArgumentException($"La línea {item.CoLin.Trim()} ya existe.");
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
        public Response Update(LinArt item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                LinArt linea = Find(item.CoLin, empresaDB);
                if (linea == null) throw new ArgumentException($"La línea {item.CoLin.Trim()} no existe.");
                
                item.RowId = linea.RowId;
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
