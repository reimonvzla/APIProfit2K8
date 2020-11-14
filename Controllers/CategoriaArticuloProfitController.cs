namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/CategoriaArticuloProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    
    public class CategoriaArticuloProfitController : ControllerBase
    {
        readonly CategoriasArticulosRepositorio metodo = new CategoriasArticulosRepositorio();
        Response resultado;

        #region GetCategorias
        // GET: api/<CategoriaArticuloProfitController>
        [HttpGet]
        [Route("GetCategorias")]
        public IEnumerable<CatArt> GetCategorias(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetCategoria
        // GET api/<CategoriaArticuloProfitController>/5
        [HttpGet("GetCategoria")]
        public CatArt GetCategoria(string CodCategoria, string Emp)
        {
            return metodo.Find(CodCategoria, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<CategoriaArticuloProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] CatArt categoria, string Emp)
        {
            categoria.CoUsIn = string.IsNullOrEmpty(categoria.CoUsIn) ? "999" : categoria.CoUsIn;
            categoria.FeUsIn = DateTime.Now;
            categoria.CoUsMo = string.Empty;
            categoria.FeUsMo = Convert.ToDateTime("01/01/1900");
            categoria.CoUsEl = string.Empty;
            categoria.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(categoria, Emp);

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
        // PUT api/<CategoriaArticuloProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] CatArt categoria, string Emp)
        {
            categoria.CoUsMo = string.IsNullOrEmpty(categoria.CoUsMo) ? "999" : categoria.CoUsMo;
            categoria.FeUsMo = DateTime.Now;
            categoria.CoUsEl = string.Empty;
            categoria.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Update(categoria, Emp);

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

        // DELETE api/<CategoriaArticuloProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
