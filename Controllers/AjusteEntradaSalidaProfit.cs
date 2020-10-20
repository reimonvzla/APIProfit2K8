namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Repositorio;

    [Route("api/AjusteEntradaSalidaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    
    public class AjusteEntradaSalidaProfit : ControllerBase
    {
        readonly AjustesEntradasSalidasRepositorio metodo = new AjustesEntradasSalidasRepositorio();
        Response resultado;

        #region GetAjustes
        // GET: api/<AjusteEntradaSalidaProfit>
        [HttpGet]
        [Route("GetAjustes")]
        public IEnumerable<EncabAjuste> GetAjustes(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetAjuste
        // GET api/<AjusteEntradaSalidaProfit>/5
        [HttpGet("GetAjuste")]
        public EncabAjuste GetAjuste(int NumAjuste, string Emp)
        {
            return metodo.Find(NumAjuste, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<AjusteEntradaSalidaProfit>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabAjuste ajuste, string Emp)
        {
            ajuste.CoUsIn = string.IsNullOrEmpty(ajuste.CoUsIn) ? "999" : ajuste.CoUsIn;
            ajuste.FeUsIn = DateTime.Now;
            ajuste.CoUsMo = string.Empty;
            ajuste.FeUsMo = Convert.ToDateTime("01/01/1900");
            ajuste.CoUsEl = string.Empty;
            ajuste.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(ajuste, Emp);
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
        // PUT api/<AjusteEntradaSalidaProfit>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        } 
        #endregion

        // DELETE api/<AjusteEntradaSalidaProfit>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
