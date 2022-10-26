using EXEMPLOPOO.Models;
using System.Globalization;

// //criando objeto/instanciando
// Pessoa pessoa1 = new Pessoa();
// pessoa1.Nome = "Teste";
// pessoa1.Idade = 24;


// pessoa1.Apresentar();





// //criando objeto contacorrte
// ContaCorrente conta = new ContaCorrente(6666,800);

// conta.Sacar(700);
// conta.ExibirSaldo();



//criando/instanciando objeto Aluno
Aluno aluno1 = new Aluno(10, "Lux" , 24);
aluno1.Apresentar();

//criando/instanciando objeto Professor
Professor professor = new Professor("Professor Teste",30, 4.550);
professor.Apresentar();








Console.WriteLine("\n");
Console.WriteLine("aperte enter para encerrar...");
Console.ReadLine();