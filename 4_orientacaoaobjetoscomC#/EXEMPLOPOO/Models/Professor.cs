namespace EXEMPLOPOO.Models
{
    public class Professor : Pessoa //Professor herda da classe Pessoa
    {

        public Professor(string nome, int idade, decimal salrio) //construtor
        {   
            Nome = nome;
            Idade = idade;
            Salario = salrio;
        }


        public decimal Salario { get; set; } //propriedade


        public override void Apresentar() //usando o polimorfismo para sobrescrever o metodo apreentar
        {
            Console.WriteLine($"Olá, meu nome é {Nome} sou professor, tenho {Idade} anos e meu salario é {Salario}");
        }


    }
}