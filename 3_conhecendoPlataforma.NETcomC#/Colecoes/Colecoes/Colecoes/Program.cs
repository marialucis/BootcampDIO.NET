using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            //trabalhando com fila(regra FIFO)

            //criando a colecao fila
            Queue<int> fila = new Queue<int>();

            //adicionando elementos a fila
            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);

            
            Console.WriteLine("Trabalhando com fila");
            foreach (int item in fila) //percorrendo a fila
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento:  {fila.Dequeue()}"); //remove elementos da fila

            fila.Enqueue(10); //adicionando novo elemento

            //imprimindo
            Console.WriteLine("Atualizando fila...");
            foreach (int item in fila)
            {
               
                Console.WriteLine(item);
            }


            Console.WriteLine("\n");
            Console.WriteLine("Trabalhando com pilha");

            //trabalhando com pilha(regra LIFO)
            //declarando a pilha
            Stack<int> pilha = new Stack<int>();

            //adiciona o elemento a pilha com o push
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Push(10);


            foreach  (int item in pilha)
            {
                Console.WriteLine(item);
            }

            //removendo com o pop
            Console.WriteLine($"Removendo elemento do topo: {pilha.Pop()}");

            Console.WriteLine("\n");
            Console.WriteLine("atualizando a pilha....");
            foreach (int item in pilha)
            {
                Console.WriteLine(item);
            }



            //trablahando com dictionary
            Console.WriteLine("\n");
            Console.WriteLine("Trabalhando com dictionary");

            Dictionary<string, string> estados = new Dictionary<string, string>();

            estados.Add("PB","Paraiba");
            estados.Add("PE", "Pernambuco");
            estados.Add("SP", "São Paulo");
            estados.Add("RJ", "Rio de Janeiro");

            

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }

            Console.WriteLine("\n");
            //removendo
            estados.Remove("RJ");


            Console.WriteLine("Removendo o estado...");
            Console.WriteLine("\n");
            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key} Valor: {item.Value}");
            }
            



            Console.WriteLine("Aperte enter para encerrar o programa...");

            Console.ReadLine();


        }
    }
}
