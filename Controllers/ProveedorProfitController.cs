namespace APIProfit2K8.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Repositorio;
    using Models;

    [Route("api/ProveedorProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class ProveedorProfitController : ControllerBase
    {
        readonly ProveedoresRespositorio metodo = new ProveedoresRespositorio();
        Response resultado = new Response();

        #region GetProveedores
        // GET: api/<ProveedorProfitController>
        [HttpGet]
        [Route("GetProveedores")]
        public IEnumerable<Prov> GetProveedores(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetProveedor
        // GET api/<ProveedorProfitController>/5
        [HttpGet("GetProveedor")]
        public Prov GetProveedor(string CodProveedor, string Emp)
        {
            return metodo.GetProveedor(CodProveedor, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<ProveedorProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Prov proveedor, string Emp)
        {
            resultado = metodo.Save(proveedor, Emp);

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
        // PUT api/<ProveedorProfitController>/5
        [HttpPut]
        [Route("Actualizar")]
        public IActionResult Actualizar([FromBody] Prov proveedor, string Emp)
        {
            resultado = metodo.Update(proveedor, Emp);
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
        // DELETE api/<ProveedorProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } 
        #endregion
    }
}
