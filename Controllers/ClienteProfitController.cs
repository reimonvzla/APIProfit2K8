namespace APIProfit2K8.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Entidades;
    using Models;
    using Repositorio;

    [Route("api/ClienteProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class ClienteProfitController : ControllerBase
    {
        readonly ClientesRepositorio metodo = new ClientesRepositorio();
        Response resultado = new Response();

        #region GetClientes
        // GET: api/<ClienteProfitController>
        [HttpGet]
        [Route("GetClientes")]
        public IEnumerable<Clientes> GetClientes(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetCliente
        // GET api/<ClienteProfitController>/5
        [HttpGet("GetCliente")]
        public Clientes GetCliente(string CodCliente, string Emp)
        {
            return metodo.GetCliente(CodCliente, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<ClienteProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Clientes cliente, string Emp)
        {
            resultado = metodo.Save(cliente, Emp);
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
        // PUT api/<ClienteProfitController>/5
        [HttpPut("Actualizar")]
        public IActionResult Actualizar([FromBody] Clientes cliente, string Emp)
        {
            resultado = metodo.Update(cliente, Emp);
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
        // DELETE api/<ClienteProfitController>/5
        [HttpDelete("Eliminar")]
        public void Eliminar(int id)
        {
        } 
        #endregion
    }
}
