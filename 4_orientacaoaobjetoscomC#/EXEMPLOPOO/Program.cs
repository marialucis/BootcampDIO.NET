using EXEMPLOPOO.Interfaces;
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



// //criando/instanciando objeto Aluno
// Aluno aluno1 = new Aluno(10, "Lux" , 24);
// aluno1.Apresentar();

// //criando/instanciando objeto Professor
// Professor professor = new Professor("Professor Teste",30, 4.550m);
// professor.Apresentar();



// Corrente c = new Corrente();
// c.Creditar(500);
// c.ExibirSaldo();

// Computador pc = new Computador();
// pc.ToString(); //metodo herdado da classe object

ICalculadora calc = new Calculadora(); //testantando interfaces
Console.WriteLine(calc.Somar(10,5));
Console.WriteLine(calc.Subtrair(10,5));
Console.WriteLine(calc.Multiplicar(10,5));
Console.WriteLine(calc.Dvidir(10,5));


Console.WriteLine("\n");
Console.WriteLine("aperte enter para encerrar...");
Console.ReadLine();