namespace APIProfit2K8.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Entidades;
    using Models;
    using Repositorio;
    using System;

    [Route("api/ArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class ArticuloProfitController : ControllerBase
    {
        readonly ArticulosRepositorio metodo = new ArticulosRepositorio();
        Response resultado = new Response();

        #region GetArticulos
        // GET: api/<ArticuloProfitController>
        [HttpGet]
        [Route("GetArticulos")]
        public IEnumerable<Art> GetArticulos(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetArticulo
        // GET api/<ArticuloProfitController>/5
        [HttpGet("GetArticulo")]
        public Art GetArticulo(string CodArticulo, string Emp)
        {
            return metodo.Find(CodArticulo, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<ArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Art articulo, string Emp)
        {
            articulo.CoUsIn = string.IsNullOrEmpty(articulo.CoUsIn) ? "999" : articulo.CoUsIn;
            articulo.FeUsIn = DateTime.Now;
            articulo.CoUsMo = string.Empty;
            articulo.FeUsMo = Convert.ToDateTime("01/01/1900");
            articulo.CoUsEl = string.Empty;
            articulo.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(articulo, Emp);
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
        // PUT api/<ArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] Art articulo, string Emp)
        {
            articulo.CoUsMo = string.IsNullOrEmpty(articulo.CoUsMo) ? "999" : articulo.CoUsMo;
            articulo.FeUsMo = DateTime.Now;
            articulo.CoUsEl = string.Empty;
            articulo.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Update(articulo, Emp);
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

        #region Eliminar
        // DELETE api/<ArticuloProfitController>/5
        [HttpDelete("Eliminar")]
        public void Eliminar(int id)
        {
        } 
        #endregion
    }
}
