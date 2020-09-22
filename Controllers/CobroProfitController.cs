namespace APIProfit2K8.Controllers
{
    using System.Collections.Generic;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Cors;
    using Entidades;
    using Repositorio;

    [Route("api/CobroProfit")]
    [ApiController]
    [EnableCors("AllowOrigin")]

    public class CobroProfitController : ControllerBase
    {

        readonly CobrosRepositorio metodo = new CobrosRepositorio();
        Response resultado = new Response();

        // GET: api/<CobroProfitController>
        [HttpGet]
        [Route("GetCobros")]
        public IEnumerable<EncabCobro> GetCobros(string Emp)
        {
            return metodo.GetAll(Emp);
        }

        // GET api/<CobroProfitController>/5
        [HttpGet("GetCobro")]
        public EncabCobro GetCobro(int NumCobro, string Emp)
        {
            return metodo.Find(NumCobro, Emp);
        }

        // POST api/<CobroProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabCobro cobro,string Emp)
        {
            resultado = metodo.Save(cobro, Emp);
            if (resultado.Status == "OK")
            {
                return Ok(resultado);
            }
            else
            {
                return BadRequest(resultado);
            }
        }

        //// PUT api/<CobroProfitController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<CobroProfitController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
