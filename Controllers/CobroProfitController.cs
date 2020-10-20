namespace APIProfit2K8.Controllers
{
    using System;
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

        #region GetCobros
        // GET: api/<CobroProfitController>
        [HttpGet]
        [Route("GetCobros")]
        public IEnumerable<EncabCobro> GetCobros(string Emp)
        {
            return metodo.GetAll(Emp);
        } 
        #endregion

        #region GetCobro
        // GET api/<CobroProfitController>/5
        [HttpGet("GetCobro")]
        public EncabCobro GetCobro(int NumCobro, string Emp)
        {
            return metodo.Find(NumCobro, Emp);
        } 
        #endregion

        #region Guardar
        // POST api/<CobroProfitController>
        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] EncabCobro cobro, string Emp)
        {
            cobro.CoUsIn = string.IsNullOrEmpty(cobro.CoUsIn) ? "999" : cobro.CoUsIn;
            cobro.FeUsIn = DateTime.Now;
            cobro.CoUsMo = string.Empty;
            cobro.FeUsMo = Convert.ToDateTime("01/01/1900");
            cobro.CoUsEl = string.Empty;
            cobro.FeUsEl = Convert.ToDateTime("01/01/1900");

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
        #endregion

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
