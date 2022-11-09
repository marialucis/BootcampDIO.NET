using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController] //criando a controller na api
    [Route("[controller]")] //criando a rota controller
    public class TesteController : ControllerBase //herda da classe base controle
    {   
        [HttpGet("TesteMes")]
        public IActionResult ObterTesteMes() //metodo
        {

           var objTeste = new
           {
               
                
           } ;    

            return Ok(objTeste);
        }
        
    }
}