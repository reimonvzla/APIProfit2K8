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
        public DocumCc Find(int key, string empresaDB)
        {
            throw new NotImplementedException();
        }

        #region GetDocumento
        public DocumCc GetDocumento(int key, string tipoDocumento, string empresaDB)
        {
            using var db = new ProfitAdmin2K8(conn.GetDbContextOptions(empresaDB));
            return db.DocumCc.FirstOrDefault(d => d.NroDoc == key && d.TipoDoc == tipoDocumento);
        } 
        #endregion


        public IEnumerable<DocumCc> GetAll(string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Remove(int key, string user, string empresaDB)
        {
            throw new NotImplementedException();
        }

        public Response Save(DocumCc item, string empresaDB)
        {
            throw new NotImplementedException();
        }

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
    }
}
