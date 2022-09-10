namespace Fundamentos_testes.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }


        public void Apresentar()
        {

            System.Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos");
        }


    }
}