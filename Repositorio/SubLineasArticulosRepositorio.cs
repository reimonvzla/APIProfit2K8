namespace APIProfit2K8.Repositorio
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Entidades;
    using Models;

    public class SubLineasArticulosRepositorio
    {

        readonly ConexionAlterna conn = new ConexionAlterna();

        #region Find
        public SubLin Find(string key, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.SubLin.FirstOrDefault(sl => sl.CoSubl.Trim() == key.Trim());
        } 
        #endregion

        #region GetAll
        public ICollection<SubLin> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.SubLin.ToList();
        } 
        #endregion

        #region Save
        public Response Save(SubLin item, string empresaDB)
        {
            try
            {
                LinArt linea = new LineasArticulosRepositorio().Find(item.CoLin, empresaDB);
                if (linea == null) throw new ArgumentException($"La línea {item.CoLin.Trim()} no existe.");

                SubLin sublinea = Find(item.CoSubl, empresaDB);
                if (sublinea != null) throw new ArgumentException($"La Sublínea {item.CoSubl.Trim()} ya existe y esta asociada a la línea {sublinea.CoLin.Trim()}.");

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
        public Response Update(SubLin item, string empresaDB)
        {
            try
            {
                SubLin sublinea = Find(item.CoSubl, empresaDB);
                if (sublinea == null) throw new ArgumentException($"La Sublinea {item.CoSubl.Trim()} no existe.");

                LinArt linea = new LineasArticulosRepositorio().Find(item.CoLin, empresaDB);
                if (linea == null) throw new ArgumentException($"La Linea {item.CoLin.Trim()} suministrada no existe.");

                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));

                FormattableString subLinea = $@"UPDATE [sub_lin] SET 
                           [subl_des] = {item.SublDes} ,[co_lin] = {item.CoLin},[campo1] = {item.Campo1},[campo2] = {item.Campo2}
                          ,[campo3] = {item.Campo3},[campo4] = {item.Campo4},[co_us_in] = {item.CoUsIn},[fe_us_in] = {item.FeUsIn}
                          ,[co_us_mo] = {item.CoUsMo},[fe_us_mo] = {item.FeUsMo},[co_us_el] = {item.CoUsEl},[fe_us_el] = {item.FeUsEl}
                          ,[revisado] = {item.Revisado},[trasnfe] = {item.Trasnfe},[co_sucu] = {item.CoSucu},[co_imun] = {item.CoImun}
                          ,[co_reten] = {item.CoReten},[i_subl_des] = {item.ISublDes},[movil] = {item.Movil} 
                          WHERE rowguid = {item.Rowguid}";
                int result = db.Database.ExecuteSqlInterpolated(subLinea);

                if (result == 1)
                {
                    return new Response { Status = "OK", Message = "Actualización realizada con éxito." };
                }
                else 
                {
                    throw new ArgumentException($"No se actualizó el registro.");
                }
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion

    }
}
