using ExemploPOO.Interfaces;

namespace ExemploPOO.Modulo
{
    public class Calculadora : iCalculadora
    { //exclusão o "dividr" da classe calculadora
        public int Multiplicar(int num1, int num2)
        {
            return num1 * num2;

        }
        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }
        public int Subtrair(int num1, int num2)
        {
            return num1 - num2;

        }
    }
}
