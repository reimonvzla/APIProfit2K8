namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Cors;
    using Microsoft.AspNetCore.Mvc;
    using Entidades;
    using Repositorio;

    [Route("api/DevolucionVentaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class DevolucionVentaProfitController : ControllerBase
    {
        readonly DevolucionesVentasRepositorio metodo = new DevolucionesVentasRepositorio();
        Response resultado;

        #region GetDevoluciones
        // GET: api/<DevolucionVentaProfitController>
        [HttpGet]
        [Route("GetDevoluciones")]
        public IEnumerable<EncabDevolucionVenta> GetDevoluciones(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetDevolucion
        // GET api/<DevolucionVentaProfitController>/5
        [HttpGet("GetDevolucion")]
        public EncabDevolucionVenta GetDevolucion(int NumDevolucion, string Emp)
        {
            return metodo.Find(NumDevolucion, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<DevolucionVentaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabDevolucionVenta devolucion, string Emp)
        {
            devolucion.CoUsIn = string.IsNullOrEmpty(devolucion.CoUsIn) ? "999" : devolucion.CoUsIn;
            devolucion.FeUsIn = DateTime.Now;
            devolucion.CoUsMo = string.Empty;
            devolucion.FeUsMo = Convert.ToDateTime("01/01/1900");
            devolucion.CoUsEl = string.Empty;
            devolucion.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(devolucion, Emp);
            
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
        // PUT api/<DevolucionVentaProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }
        #endregion

        #region Eliminar
        // DELETE api/<DevolucionVentaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } 
        #endregion
    }
}
