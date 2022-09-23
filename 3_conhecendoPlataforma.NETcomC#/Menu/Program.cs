// See https://aka.ms/new-console-template for more information


bool opcEscolha = true;

while (true)
{
    Console.WriteLine("Escolha uma opção");
    Console.WriteLine("1- Cadastrar Cliente");
    Console.WriteLine("2- Pesquisar Cliente");
    Console.WriteLine("3- Deletar Cliente");
    Console.WriteLine("4- Encerrar");
    
    int opc = int.Parse(Console.ReadLine());
    



    switch (opc)
    {
       case 1: 
            Console.WriteLine("Cadastrar Cliente");     
       break;

       case 2:
            Console.WriteLine("Pesquisar Cliente");
       break; 

       case 3:
            Console.WriteLine("Deletar Cliente");
            break;

        default:
        Environment.Exit(0);
        break;
    }
}