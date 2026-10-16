using Microsoft.AspNetCore.Mvc;
using UbcApi.Models;
using UbcApi.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UbcApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        MedicoService medicoFuncao = new MedicoService();
        // GET: api/<MedicoController>
        [HttpGet]
        public IActionResult GetListarMedicos()
        {
            List<MedicoModel> listaMedicoContoeller = medicoFuncao.ListarMedicos();
            return Ok(listaMedicoContoeller);
        }

        // GET api/<MedicoController>/5
        [HttpGet("{crm}")]
        
        public IActionResult GetMedico(string crm)
        {
            MedicoModel medicoEncontrado = medicoFuncao.BuscarMedico(crm);
            if (medicoEncontrado != null)
            {
                return Ok(medicoEncontrado);
            }
           return BadRequest();
        }
         
        // POST api/<MedicoController>
        //[HttpPost]
        //public string Post([FromBody] string value)
        //{
        //    if (medicoFuncao.CadastrarMedico())
        //    {
        //        return "Cadastro realizado com sucesso!";
        //    }
        //    return "Cadastro não realizado.";
        //}

        // PUT api/<MedicoController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MedicoController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
