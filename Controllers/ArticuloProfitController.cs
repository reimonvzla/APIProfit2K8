namespace APIProfit2K8.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Entidades;
    using Models;
    using Repositorio;

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
