namespace APIProfit2K8.Controllers
{
    using System;
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Entidades;
    using Repositorio;


    [Route("api/FacturaVentaProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class FacturaVentaProfitController : ControllerBase
    {
        readonly FacturasVentasRepositorio metodo = new FacturasVentasRepositorio();
        Response resultado = new Response();

        #region GetFacturas
        // GET: api/<FacturaVentaProfitController>
        [HttpGet]
        [Route("GetFacturas")]
        public IEnumerable<EncabFacturaVenta> GetFacturas(string Emp)
        {
            return metodo.GetAll(Emp);
        }
        #endregion

        #region GetFactura
        // GET api/<FacturaVentaProfitController>/5
        [HttpGet("GetFactura")]
        public EncabFacturaVenta GetFactura(int NumFactura, string Emp)
        {
            return metodo.Find(NumFactura, Emp);
        }
        #endregion

        #region Guardar
        // POST api/<FacturaVentaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabFacturaVenta factura, string Emp)
        {
            factura.CoUsIn = string.IsNullOrEmpty(factura.CoUsIn) ? "999" : factura.CoUsIn;
            factura.FeUsIn = DateTime.Now;
            factura.CoUsMo = string.Empty;
            factura.FeUsMo = Convert.ToDateTime("01/01/1900");
            factura.CoUsEl = string.Empty;
            factura.FeUsEl = Convert.ToDateTime("01/01/1900");

            resultado = metodo.Save(factura, Emp);
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
        // PUT api/<FacturaVentaProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        #endregion

        #region Eliminar
        // DELETE api/<FacturaVentaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        } 
        #endregion
    }
}
