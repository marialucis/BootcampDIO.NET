using EXEMPLOPOO.Interfaces;

namespace EXEMPLOPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Dvidir(int n1, int n2)
        {
           return n1 / n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}