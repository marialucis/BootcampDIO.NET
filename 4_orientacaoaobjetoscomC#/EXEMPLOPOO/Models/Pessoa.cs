namespace EXEMPLOPOO.Models
{
    public class Pessoa
    {   
        public Pessoa()
        {
            
        }

        public Pessoa(string nome) //construtor por herença
        {
             Nome = nome;   
        }
        //Testando Abstracao
        public string Nome { get; set; }
        public int Idade { get; set; }


        public virtual void Apresentar() //Polimorfismo....utilizando o metdo virtual no metodo para poder sobrescrever 
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos!");
        }

    }
}