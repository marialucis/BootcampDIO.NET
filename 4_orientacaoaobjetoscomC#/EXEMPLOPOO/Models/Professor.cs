namespace EXEMPLOPOO.Models
{
    // classe selada(sealed) não pode ser herdada
    public /*sealed*/ class Professor : Pessoa //Professor herda da classe Pessoa
    {
        public Professor()
        {

        }
        public Professor(string nome, int idade, decimal salrio) : base(nome) //construtor
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