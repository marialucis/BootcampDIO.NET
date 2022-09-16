// See https://aka.ms/new-console-template for more information

Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());

for (int contador = 0; contador < 11 ; contador++)
{
    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
}