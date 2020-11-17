namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Models;
    using Repositorio;
    using Entidades;

    [Route("api/SubLineaArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class SubLineaArticuloProfitController : ControllerBase
    {
        readonly SubLineasArticulosRepositorio metodo = new SubLineasArticulosRepositorio();
        Response resultado;

        #region GetSublineas
        // GET: api/<SubLineaArticuloProfitController>
        [HttpGet]
        [Route("GetSublineas")]
        public IEnumerable<SubLin> GetSublineas(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetSublinea
        // GET api/<SubLineaArticuloProfitController>/5
        [HttpGet("GetSublinea")]
        public SubLin GetSublinea(string CodSublinea, string Emp)
        {
            return metodo.Find(CodSublinea, Emp);
        }
        #endregion

        #region GetSublineaxLinea
        // GET api/<SubLineaArticuloProfitController>/5
        [HttpGet("GetSublineaxLinea")]
        public SubLin GetSublineaxLinea(string CodSublinea, string CodLinea,string Emp)
        {
            return metodo.FindxLinea(CodSublinea, CodLinea, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<SubLineaArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] SubLin sublinea, string Emp)
        {
            sublinea.CoUsIn = string.IsNullOrEmpty(sublinea.CoUsIn) ? "999" : sublinea.CoUsIn;
            sublinea.FeUsIn = DateTime.Now;
            sublinea.CoUsMo = string.Empty;
            sublinea.FeUsMo = Convert.ToDateTime("01/01/1900");
            sublinea.CoUsEl = string.Empty;
            sublinea.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(sublinea, Emp);

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
        // PUT api/<SubLineaArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] SubLin sublinea, string Emp)
        {
            sublinea.CoUsMo = string.IsNullOrEmpty(sublinea.CoUsMo) ? "999" : sublinea.CoUsMo;
            sublinea.FeUsMo = DateTime.Now;
            sublinea.CoUsEl = string.Empty;
            sublinea.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Update(sublinea, Emp);

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

        // DELETE api/<SubLineaArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
