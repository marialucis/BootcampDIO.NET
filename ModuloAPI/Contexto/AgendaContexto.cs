using Microsoft.EntityFrameworkCore;
using ModuloAPI.Entities;

namespace ModuloAPI.Contexto
{
    public class AgendaContexto : DbContext // herdanos essa classe vem do pacote 
    
    {
        public AgendaContexto(DbContextOptions<AgendaContexto> options) : base(options) //construtor que recebe a configuração de conexao banco
        {

        }


        public DbSet<Contato> Contatos{get; set;} //representa a tabela
    }
}