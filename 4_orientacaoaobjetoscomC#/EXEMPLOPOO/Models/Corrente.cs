namespace EXEMPLOPOO.Models
{
    /*herda da classe conta que é uma classe abstrata usada de modelo para outras 
    classes, elas não podem ser instanciadas  
    */
    public class Corrente : Conta   
    {
        public override void Creditar(decimal valor)
        {
            saldo += valor;
        }
    }
}