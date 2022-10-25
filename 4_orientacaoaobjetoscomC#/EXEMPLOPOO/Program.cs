using EXEMPLOPOO.Models;


//criando objeto/instanciando
Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Teste";
pessoa1.Idade = 24;


pessoa1.Apresentar();





//criando objeto contacorrte
ContaCorrente conta = new ContaCorrente(6666,800);

conta.Sacar(700);
conta.ExibirSaldo();













Console.WriteLine("\n");
Console.WriteLine("aperte enter para encerrar...");
Console.ReadLine();