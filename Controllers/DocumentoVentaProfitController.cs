namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/DocumentoVentaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class DocumentoVentaProfitController : ControllerBase
    {
        readonly DocumentosVentasRepositorio metodo = new DocumentosVentasRepositorio();
        Response resultado;

        #region GetDocumentos
        // GET: api/<DocumentoVentaProfitController>
        [HttpGet]
        [Route("GetDocumentos")]
        public IEnumerable<DocumCc> GetDocumentos(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetDocumentosPorTipo
        // GET: api/<DocumentoVentaProfitController>
        [HttpGet]
        [Route("GetDocumentosPorTipo")]
        public IEnumerable<DocumCc> GetDocumentosPorTipo(string TipoDocumento, string Emp)
        {
            return metodo.GetAllbyTipoDoc(TipoDocumento, Emp);
        }
        #endregion

        #region GetDocumento
        // GET api/<DocumentoVentaProfitController>/5
        [HttpGet("GetDocumento")]
        public DocumCc GetDocumento(int NumDocumento, string TipoDocumento, string Emp)
        {
            return metodo.GetDocumento(NumDocumento, TipoDocumento, Emp);
        }
        #endregion

        #region GetDocumentosPorCliente
        // GET: api/<DocumentoVentaProfitController>
        [HttpGet]
        [Route("GetDocumentosPorCliente")]
        public IEnumerable<DocumCc> GetDocumentosPorCliente(string TipoDocumento, string Emp,string CodCliente)
        {
            return metodo.GetAllTipoDocbyClient(TipoDocumento, Emp, CodCliente);
        }
        #endregion

        #region Guardar
        // POST api/<DocumentoVentaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] DocumCc documento, string Emp)
        {
            documento.CoUsIn = string.IsNullOrEmpty(documento.CoUsIn) ? "999" : documento.CoUsIn;
            documento.FeUsIn = DateTime.Now;
            documento.CoUsMo = string.Empty;
            documento.FeUsMo = Convert.ToDateTime("01/01/1900");
            documento.CoUsEl = string.Empty;
            documento.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(documento, Emp);
            if (resultado.Status == "OK")
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest(resultado);
            }
        }
        #endregion

        #region Actualizar
        // PUT api/<DocumentoVentaProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] DocumCc documento, string Emp)
        {
            resultado = metodo.Update(documento, Emp);
            if (resultado.Status == "OK")
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest(resultado);
            }
        } 
        #endregion

        // DELETE api/<DocumentoVentaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
