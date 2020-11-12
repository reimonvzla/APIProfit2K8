namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/LineaArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class LineaArticuloProfitController : ControllerBase
    {
        readonly LineasArticulosRepositorio metodo = new LineasArticulosRepositorio();
        Response resultado;

        #region GetLineas
        // GET: api/<LineaArticuloProfitController>
        [HttpGet]
        [Route("GetLineas")]
        public IEnumerable<LinArt> GetLineas(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetLinea
        // GET api/<LineaArticuloProfitController>/5
        [HttpGet("GetLinea")]
        public LinArt GetLinea(string CodLinea, string Emp)
        {
            return metodo.Find(CodLinea, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<LineaArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] LinArt linea, string Emp)
        {
            linea.CoUsIn = string.IsNullOrEmpty(linea.CoUsIn) ? "999" : linea.CoUsIn;
            linea.FeUsIn = DateTime.Now;
            linea.CoUsMo = string.Empty;
            linea.FeUsMo = Convert.ToDateTime("01/01/1900");
            linea.CoUsEl = string.Empty;
            linea.FeUsEl = Convert.ToDateTime("01/01/1900");
            
            resultado = metodo.Save(linea, Emp);
            
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
        // PUT api/<LineaArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] LinArt linea, string Emp)
        {
            linea.CoUsMo = string.IsNullOrEmpty(linea.CoUsMo) ? "999" : linea.CoUsMo;
            linea.FeUsMo = DateTime.Now;
            linea.CoUsEl = string.Empty;
            linea.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Update(linea, Emp);

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

        // DELETE api/<LineaArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
