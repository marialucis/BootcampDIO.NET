using Microsoft.AspNetCore.Mvc;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
            [HttpGet("ObterDataHoraAtual")] //nome do metodo na api via swagger
            public IActionResult ObterDataHora()

            {
               var obj = new
               {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortTimeString()
               };
               return Ok(obj);
               
            }

            [HttpGet("Apresenta/{nome}/{idade}/{email}")] //metodo com parametros
            public IActionResult Apresentar(string nome , int idade , string email)
            {
                 var mensagem = $"Olá {nome}, você tem {idade} anos e esse é seu e-maill: {email}!";
                  return Ok(new { mensagem });

            }



    }
}