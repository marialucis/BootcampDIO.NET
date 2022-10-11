// See https://aka.ms/new-console-template for more information


// //declarando variaveis
 bool ehpar = false;


 Console.WriteLine("Digite um numero: ");
int numero = int.Parse(Console.ReadLine());


//if ternario

ehpar = numero % 2 == 0;
Console.WriteLine($"O numero {numero} é " +(ehpar ? "par" : "impar"));




System.Console.WriteLine("Aperte enter para encerrar...");
Console.ReadLine();
