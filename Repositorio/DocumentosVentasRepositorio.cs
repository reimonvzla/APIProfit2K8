namespace APIProfit2K8.Repositorio
{
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Entidades;
using Models;

    public class DocumentosVentasRepositorio : IRepositorio<DocumCc>
    {
        readonly ConexionAlterna conn = new ConexionAlterna();
       
        #region Find
        public DocumCc Find(int key, string empresaDB)
        {
            throw new NotImplementedException();
        } 
        #endregion

        #region GetDocumento
        public DocumCc GetDocumento(int key, string tipoDocumento, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.DocumCc.FirstOrDefault(d => d.NroDoc == key && d.TipoDoc.Trim() == tipoDocumento);
        }
        #endregion

        #region GetAll
        public IEnumerable<DocumCc> GetAll(string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.DocumCc.ToList();
        }
        #endregion

        #region GetAll por TipoDoc
        public IEnumerable<DocumCc> GetAllbyTipoDoc(string TipoDoc, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.DocumCc.Where(dc=>dc.TipoDoc.Trim() == TipoDoc.Trim()).ToList();
        }
        #endregion

        #region Remove
        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Save
        public Response Save(DocumCc item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                Utilitarios utilitarios = new Utilitarios();
                
                #region Buscar consecutivo
                int numeroDocumento = utilitarios.BuscarConsecutivo(item.TipoDoc.Trim(), item.CoSucu, empresaDB);
                #endregion

                Clientes cliente = new ClientesRepositorio().GetCliente(item.CoCli, empresaDB);
                if (cliente == null) throw new ArgumentException($"El cliente {item.CoCli.Trim()} no existe.");
                Vendedor vendedor = new VendedoresRepositorio().Find(item.CoVen, empresaDB);
                if (vendedor == null) throw new ArgumentException($"El vendedor {item.CoVen.Trim()} no existe.");

                #region Construcción de DisCen
                string DisCen = utilitarios.ArmarDisCen(item.FecEmis, item.MontoBru, item.MontoImp, (item.Tipo == "6") ? item.MontoNet : 0, empresaDB);
                #endregion

                item.NroDoc = numeroDocumento;
                item.Contrib = cliente.Contribu;
                item.DisCen = DisCen;
                db.Entry(item).State = EntityState.Added;
                db.SaveChanges();

                #region Actualizar consecutivo
                utilitarios.ActualizarConsecutivo(numeroDocumento, item.TipoDoc.Trim(), item.CoSucu, empresaDB);
                #endregion

                return new Response { Status = "OK", Message = "Transacción realizada con éxito", FacturaID = item.NroDoc.ToString() };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        }
        #endregion

        #region Update
        public Response Update(DocumCc item, string empresaDB)
        {
            try
            {
                using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return new Response { Status = "OK", Message = $"Actualizado el documento {item.TipoDoc} {item.NroDoc}." };
            }
            catch (Exception ex)
            {
                return new Response { Status = "ERROR", Message = (ex.InnerException != null) ? ex.InnerException.Message : ex.Message };
            }
        } 
        #endregion
    }
}
