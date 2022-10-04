namespace Fundamentos_part2.Models
{
    public class Pessoa
    {
        //criando campo para utilizar a propriedade
        private string _nome;
        private int _idade;
        //propriedades
        public string Nome
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if (value == "")
                {
                    throw new ArgumentException("O nome está vazio"); //criando excecao
                }

                _nome = value;
            }

        }
        public int Idade 
        { 
            get => _idade;
        
         set
         {
            if (value < 0)
            {
            throw new ArgumentException("A idade está vazio");
            }

            _idade = value;

         }
         
          }


        //metodos
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");

        }

        




    }


}