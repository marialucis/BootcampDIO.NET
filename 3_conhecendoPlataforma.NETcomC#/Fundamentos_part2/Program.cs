// See https://aka.ms/new-console-template for more information
using Fundamentos_part2.Models;
{
    //variaveis
    int opc = 0;
    bool exibeMenu = true;
    

    //instanciando a classe e suas propriedades
    Pessoa pessoa = new Pessoa();

   // pessoa.Nome = "Teste" ;
    //pessoa.Idade = 12 ;
    //pessoa.Apresentar();
    
    //instanciando a clsse Curso
    Curso curso = new Curso();

    while (exibeMenu)
    {
        
        Console.WriteLine("1- Adicionar Aluno");
        Console.WriteLine("2- Remover Aluno");
        Console.WriteLine("3- Listar Alunos");
        Console.WriteLine("4- Obter Alunos Matriculados");
        Console.WriteLine("0- SAIR");
        Console.WriteLine("Escolha a opção");
        opc = int.Parse(Console.ReadLine());

        
        switch (opc)
        {   
            // case 1:
            //     curso.AdicionarAluno();     
            // break;
            
            // case 2:
            //     curso.RemoverAluno();     
            // break;

            case 3:
                curso.ListarAlunos();     
            break;
            
            case 4:
                curso.ObterAlunosMatriculados();     
            break;
            
            
            default:
                Console.WriteLine("Opção Invalida");
                exibeMenu = false;
                Environment.Exit(0);
            break;
        }

    }
        Console.ReadLine();

}
