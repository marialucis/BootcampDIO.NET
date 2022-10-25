namespace EXEMPLOPOO.Models
{
    //testando encapsulamento
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }

        public int NumeroConta { get; set; }
        private decimal saldo;



        public void Sacar(decimal valor)
        {   
            if (saldo >= valor)
            {
                saldo -= valor;

                Console.WriteLine("Saque realizado!");
            }
            else
            {
                Console.WriteLine("Saldo indisponivel!");
            }
        }


        public void ExibirSaldo()
        {
          Console.WriteLine($"O saldo atual: {saldo}");
        }


    }
}