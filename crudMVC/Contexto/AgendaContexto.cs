using crudMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace crudMVC.Contexto
{
    public class AgendaContexto : DbContext 
    {
        public AgendaContexto(DbContextOptions<AgendaContexto> options) : base(options)
        {

        }


        public DbSet<Contato> Contatos{get; set;} //representa a tabela
    }
}