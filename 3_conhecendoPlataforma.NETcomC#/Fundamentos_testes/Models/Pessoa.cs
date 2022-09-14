namespace Fundamentos_testes.Models
{
    public class Pessoa
    {
        //atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }



        public void Apresentar()
        {

            System.Console.WriteLine($"Ola, meu nome é {Nome} e tenho {Idade} anos Meus contatos: {Telefone}, {Email}");
        }


    }
}