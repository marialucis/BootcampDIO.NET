namespace EXEMPLOPOO.Models
{
    public abstract class Conta //classe abstrata usada apenas para modelo
    {

        protected decimal saldo;

        public abstract void Creditar(decimal valor);

        public void ExibirSaldo()
        {
            Console.WriteLine("O seu saldo é: " +saldo);
        }
        
    }
}