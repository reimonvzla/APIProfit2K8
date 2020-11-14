namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ColorArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    
    public class ColorArticuloProfitController : ControllerBase
    {
        readonly ColoresArticulosRepositorio metodo = new ColoresArticulosRepositorio();
        Response resultado;

        #region GetColores
        // GET: api/<ColorArticuloProfitController>
        [HttpGet]
        [Route("GetColores")]
        public IEnumerable<Colores> GetColores(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetColor
        // GET api/<ColorArticuloProfitController>/5
        [HttpGet("Getcolor")]
        public Colores Getcolor(string CodColor, string Emp)
        {
            return metodo.Find(CodColor, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<ColorArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Colores color, string Emp)
        {
            color.CoUsIn = string.IsNullOrEmpty(color.CoUsIn) ? "999" : color.CoUsIn;
            color.FeUsIn = DateTime.Now;
            color.CoUsMo = string.Empty;
            color.FeUsMo = Convert.ToDateTime("01/01/1900");
            color.CoUsEl = string.Empty;
            color.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(color, Emp);
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
        // PUT api/<ColorArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] Colores color, string Emp)
        {
            color.CoUsMo = string.IsNullOrEmpty(color.CoUsMo) ? "999" : color.CoUsMo;
            color.FeUsMo = DateTime.Now;
            color.CoUsEl = string.Empty;
            color.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Update(color, Emp);
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

        // DELETE api/<ColorArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
