// See https://aka.ms/new-console-template for more information
Console.WriteLine("Testando Listas!");

//declarando a lista
List<string> lista = new List<string>(); 
lista.Add("AM");
lista.Add("PB");
lista.Add("PE");

foreach (string item in lista)
{
    Console.WriteLine(item);
}
