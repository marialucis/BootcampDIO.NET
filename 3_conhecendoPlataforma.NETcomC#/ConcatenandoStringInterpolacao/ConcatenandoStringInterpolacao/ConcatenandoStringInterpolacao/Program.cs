using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenandoStringInterpolacao
{
    class Program
    {
        static void Main(string[] args)
        {

            string Nome = " ";
            string SobreNome = " ";

            Console.WriteLine("Digite o seu Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite o seu Sobrenome: ");
            SobreNome = Console.ReadLine();


            string NomeCompleto = Nome + SobreNome;

            ////concatenando string
            Console.WriteLine("Nome Completo: " +NomeCompleto);



            //interpolacao

            Console.WriteLine($"Nome Completo: {Nome} {SobreNome}");






            Console.ReadLine();

        }
    }
}
