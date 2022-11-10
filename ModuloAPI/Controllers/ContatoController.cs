using Microsoft.AspNetCore.Mvc;
using ModuloAPI.Entities;
using ModuloAPI.Contexto;

namespace ModuloAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContexto _contexto;
        public ContatoController(AgendaContexto contexto)
        {
              _contexto = contexto;
        }
        [HttpPost("CriarContato")] //endpoint
        public IActionResult Create(Contato contato) //metodo criar/inserir na tabela
        {
            _contexto.Add(contato);
            _contexto.SaveChanges();
            return Ok(contato);
        }

        [HttpGet("{id}")] //enpoint
        public IActionResult ObterId(int id) //metodo select para consulta
        {
            var contato = _contexto.Contatos.Find(id);

              if (contato == null){
            return NotFound();
           } 

            return Ok(contato);
        }


        [HttpPut("{id}")] //endpoint
         public IActionResult Atualizar(int id, Contato contato) //metodo atualizar
        {
            var contatoBanco = _contexto.Contatos.Find(id);

              if (contatoBanco == null){
            return NotFound();
           } 

           contatoBanco.Nome = contato.Nome;
           contatoBanco.Telefone = contato.Telefone;
           contatoBanco.Ativo = contato.Ativo;

            _contexto.Contatos.Update(contatoBanco);
            _contexto.SaveChanges();


            return Ok(contatoBanco);
        }



        [HttpDelete("{id}")] //endpoint
        public IActionResult Deletar(int id) //metodo deletar databela
        {
          var contato = _contexto.Contatos.Find(id);

           if (contato == null){
            return NotFound();
           } 

            _contexto.Remove(contato);
            _contexto.SaveChanges();
            return NoContent();
        }



        
        [HttpGet("ObterPorNome/{nome}")] //enpoint
        public IActionResult ObterPorNome(string nome) //metodo select para consulta
        {
            var contato = _contexto.Contatos.Where(x => x.Nome.Contains(nome));

            return Ok(contato);
        }

    }
}