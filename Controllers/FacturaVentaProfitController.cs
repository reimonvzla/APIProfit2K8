namespace APIProfit2K8.Controllers
{
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

        // GET: api/<FacturaVentaProfitController>
        [HttpGet]
        [Route("GetFacturas")]
        public IEnumerable<EncabFacturaVenta> GetFacturas(string Emp)
        {
            return metodo.GetAll(Emp);
        }

        // GET api/<FacturaVentaProfitController>/5
        [HttpGet("GetFactura")]
        public EncabFacturaVenta GetFactura(int NumFactura,string Emp)
        {
            return metodo.Find(NumFactura, Emp);
        }

        // POST api/<FacturaVentaProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabFacturaVenta factura,string Emp)
        {
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

        // PUT api/<FacturaVentaProfitController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        
        }

        // DELETE api/<FacturaVentaProfitController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
