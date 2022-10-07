using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.IO;

namespace Excecao
{
    class Program
    {
        static void Main(string[] args)
        {



            //fazendo a leitura do arquivo/ tratamento de excecao

            try
            {
                string[] linhas = File.ReadAllLines("D:/Repositorio_git/12_BootcampDIOC#/3_conhecendoPlataforma.NETcomC#/TrabalhandoExcecoes/Excecao/Excecao/Arquivos/arquivoLeitura.txt");

                foreach (string linha in linhas)
                {
                    Console.WriteLine(linha);
                }

            }

            catch (FileNotFoundException ex) //excecao especificia
            {
                Console.WriteLine($"Ocorreu um erro de leitura de arquivo. Arquivo não encontrado. {ex.Message}");

            }

            catch (DirectoryNotFoundException ex) //excecao especificia
            {
                Console.WriteLine($"Ocorreu um erro de leitura de arquivo. Pasta não encontrada. {ex.Message}");

            }
            catch (Exception ex) //excecao generica
            {

                Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Chegou até aqui");
            }



















            //fazendo a leitura do arquivo/ tratamento de excecao com throw

            //try
            //{
            //    string[] linhas = File.ReadAllLines("D:/Repositorio_git/12_BootcampDIOC#/3_conhecendoPlataforma.NETcomC#/TrabalhandoExcecoes/Excecao/Excecao/Arquivos/arquivoLeitura.txt");

            //    foreach (string linha in linhas)
            //    {
            //        Console.WriteLine(linha); 
            //    }

            //}

            //catch (FileNotFoundException ex) //excecao especificia
            //{
            //    throw new ArgumentException($"Ocorreu um erro de leitura de arquivo. Arquivo não encontrado. {ex.Message}");

            //}

            //catch (DirectoryNotFoundException ex) //excecao especificia
            //{
            //    throw new ArgumentException($"Ocorreu um erro de leitura de arquivo. Pasta não encontrada. {ex.Message}");

            //}
            //catch (Exception ex) //excecao generica
            //{

            //    throw new ArgumentException($"Ocorreu uma exceção genérica. {ex.Message}");
            //}
            //finally
            //{
            //    Console.WriteLine("Chegou até aqui"); 
            //}



            Console.ReadLine();



        }
    }
}
