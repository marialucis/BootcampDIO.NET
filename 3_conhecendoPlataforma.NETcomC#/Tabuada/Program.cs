// See https://aka.ms/new-console-template for more information

//usando while

int numero = 5;
int contador = 0;

while (contador <= 10)
{
    Console.WriteLine($"{numero} * {contador} = {numero * contador}");
    contador++;
   
    
    if (contador == 11)
    {
        break; //qubra o laco
    }
}









// //usando for
// Console.WriteLine("Digite um numero: ");
// int numero = int.Parse(Console.ReadLine());

// for (int contador = 0; contador < 11 ; contador++)
// {
//     Console.WriteLine($"{numero} * {contador} = {numero * contador}");
// }