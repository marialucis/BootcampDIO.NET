using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using PacotesEJson.Models;
using Newtonsoft.Json;
using System.IO;


namespace PacotesEJson
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime DataAtual = DateTime.Now;

            //instanciando a classe venda
            Vendas venda1 = new Vendas(1, "Material de ação", 25.00M, "TesteVendedor",DataAtual);
            Vendas venda2 = new Vendas(2, "Luvas Teste", 100.50M,"Luci Vendas", DataAtual);
            Vendas venda3 = new Vendas(3, "Monitor Acer", 687.59M, "TesteVendedor", DataAtual);
            


            //serializando o objeto e realizando a identacao do json
            Console.WriteLine("Produto 1: ");
            string serializado = JsonConvert.SerializeObject(venda1, Formatting.Indented);
            Console.WriteLine(serializado);

            Console.WriteLine("\n");

            Console.WriteLine("Produto 2: ");
            string serializado2 = JsonConvert.SerializeObject(venda2, Formatting.Indented);
            Console.WriteLine(serializado2);

            Console.WriteLine("\n");

            Console.WriteLine("Produto 3: ");
            string serializado3 = JsonConvert.SerializeObject(venda3, Formatting.Indented);
            Console.WriteLine(serializado3);



            Console.WriteLine("\n");


            //escrevendo um  arquivo json para envio e criacao na pasta
            File.WriteAllText("D:/Repositorio_git/12_BootcampDIOC#/3_conhecendoPlataforma.NETcomC#/NugetSerializacaoAtributos/PacotesEJson/PacotesEJson/Arquivos/vendas.json", serializado);
            File.WriteAllText("D:/Repositorio_git/12_BootcampDIOC#/3_conhecendoPlataforma.NETcomC#/NugetSerializacaoAtributos/PacotesEJson/PacotesEJson/Arquivos/vendas2.json", serializado2);


            //criando uma lista para agrupar os objetos serializados
            List<Vendas> listaVendas = new List<Vendas>();
            listaVendas.Add(venda1);
            listaVendas.Add(venda2);
            listaVendas.Add(venda3);

            //serializando o objeto tipo coleção que são as listas
            string lista = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

            //escrevendo o arquivo json
            File.WriteAllText("D:/Repositorio_git/12_BootcampDIOC#/3_conhecendoPlataforma.NETcomC#/NugetSerializacaoAtributos/PacotesEJson/PacotesEJson/Arquivos/lista.json", lista);







            Console.WriteLine("Clique para encerrar o programa...");
            Console.ReadLine();
        }
    }
}
