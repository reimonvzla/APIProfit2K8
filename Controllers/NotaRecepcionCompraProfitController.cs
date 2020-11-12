namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Repositorio;

    [Route("api/NotaRecepcionCompraProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    
    public class NotaRecepcionCompraProfitController : ControllerBase
    {

        readonly NotasRecepcionComprasRepositorio metodo = new NotasRecepcionComprasRepositorio();
        Response resultado;

        #region GetNotasRecepcion
        // GET: api/<NotaRecepcionCompraProfitController>
        [HttpGet]
        [Route("GetNotasRecepcion")]
        public IEnumerable<EncabNotRec> GetNotasRecepcion(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetNotaRecepcion
        // GET api/<NotaRecepcionCompraProfitController>/5
        [HttpGet("GetNotaRecepcion")]
        public EncabNotRec GetNotaRecepcion(int NumNotaRecepcion, string Emp)
        {
            return metodo.Find(NumNotaRecepcion, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<NotaRecepcionCompraProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabNotRec nota, string Emp)
        {
            nota.CoUsIn = string.IsNullOrEmpty(nota.CoUsIn) ? "999" : nota.CoUsIn;
            nota.FeUsIn = DateTime.Now;
            nota.CoUsMo = string.Empty;
            nota.FeUsMo = Convert.ToDateTime("01/01/1900");
            nota.CoUsEl = string.Empty;
            nota.FeUsEl = Convert.ToDateTime("01/01/1900");
            resultado = metodo.Save(nota, Emp);
            
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
        // PUT api/<NotaRecepcionCompraProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        #endregion

        #region Eliminar
        // DELETE api/<NotaRecepcionCompraProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } 
        #endregion
    }
}
