using Microsoft.AspNetCore.Mvc;
using crudMVC.Contexto;
using crudMVC.Controllers;
using crudMVC.Models;


namespace crudMVC.Controllers
{
    public class ContatoController : Controller
    {
        //adicionando o ef
        private readonly AgendaContexto _contexto;

        public ContatoController(AgendaContexto contexto)
        {
            _contexto = contexto;
        }
        //metodo para retornar a view/ pag index 
        public IActionResult Index()
        {
            var contatos = _contexto.Contatos.ToList();
            return View(contatos);
        }

        //metodo para retornar a view/pag criar  (metodo get)
        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(Contato contato) //metodo que cria o contato
        {   
            if (ModelState.IsValid)
            {
                _contexto.Contatos.Add(contato);
                _contexto.SaveChanges();
                return  RedirectToAction(nameof(Index));
            }
            return View(contato);
        }


        //metodo editar
        
        public IActionResult Editar(int id) //metodo que cria o contato
        {   
           var contato = _contexto.Contatos.Find(id);

            if (contato == null)
            {
                return RedirectToAction(nameof(Index)); 
            }
           return View(contato);

        }
        [HttpPost] //metodo para editar o contato 
        public IActionResult Editar(Contato contato)
        {
            var contatoBanco = _contexto.Contatos.Find(contato.Id);

            contatoBanco.Nome = contato.Nome;
            contatoBanco.Telefone = contato.Telefone;
            contatoBanco.Ativo = contato.Ativo;


            _contexto.Contatos.Update(contatoBanco);
            _contexto.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        //metodo detalhar(get)
        public IActionResult Detalhes(int id)
        {
            var contato = _contexto.Contatos.Find(id);
            
            if (contato == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }


        //metodo deletar
        public IActionResult Deletar(int id)
        {
            var contato = _contexto.Contatos.Find(id);
            
            if (contato == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(contato);
        }

          [HttpPost] //metodo para deletar o contato 
        public IActionResult Deletar(Contato contato)
        {
            var contatoBanco = _contexto.Contatos.Find(contato.Id);


            _contexto.Contatos.Remove(contatoBanco);
            _contexto.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}