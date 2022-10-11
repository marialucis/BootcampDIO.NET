using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuplasOpeTernario
{
    class Program
    {
        static void Main(string[] args)
        {

            (int, string, string, decimal) tupla = (1, "Lux", "Teste", 1.52M);  //testando tupla(declarando os tipos de dados atraves de uma unica variavel tupla)
            Console.WriteLine($"ID: {tupla.Item1}");
            Console.WriteLine($"Nome: {tupla.Item2}");
            Console.WriteLine($"Sobrenome: {tupla.Item3}");
            Console.WriteLine($"Altura: {tupla.Item4}");

            Console.WriteLine("\n");

            //outra forma de declarar tuplas
            //usando o ValueTuple

            ValueTuple<int, string, string, decimal> outroExemploTupla = (2, "Luxi", "Testes", 1.52M);

            Console.WriteLine($"ID: {outroExemploTupla.Item1}");
            Console.WriteLine($"Nome: {outroExemploTupla.Item2}");
            Console.WriteLine($"Sobrenome: {outroExemploTupla.Item3}");
            Console.WriteLine($"Altura: {outroExemploTupla.Item4}");







            Console.ReadLine();
        }


        
    }
}
