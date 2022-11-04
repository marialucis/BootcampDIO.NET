using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//instanciando a classe nokia
Nokia nokia = new Nokia();
Console.WriteLine($"O numero é: {nokia.Numero ="523819"}");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Instagram");


Console.WriteLine("\n");

//instanciando iphone

Iphone iphone = new Iphone();
Console.WriteLine($"O numero é: {iphone.Numero = "10101010"}");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Tinder");







Console.WriteLine("Aperte qualquer tecla para encerrar...");
Console.ReadLine();