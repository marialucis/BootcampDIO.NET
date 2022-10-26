namespace EXEMPLOPOO.Models
{
    public class Aluno : Pessoa //Aluno herda da classe Pessoa
    {

        public Aluno(int nota, string nome, int idade){
            Nota = nota;
            Nome = nome;
            Idade = idade;
        }

        public double Nota { get; set; }


        public override void Apresentar() //utilizando o metodo override para o Polimorfismo em tempo de exececao
        {
         Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e sou uma Aluna nota {Nota}");
        }

    }
}