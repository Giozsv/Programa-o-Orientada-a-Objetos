namespace ExemploPOO.Modulo
{
    public abstract class Conta
    {
        protected double saldo;

        /// ABSTRATO = OBRIGATÓRIO IMPLEMENTAR/SOBRESCREVER 
        public abstract void Creditar(double valor);
        public void ExibirSaldo()
        {
            System.Console.WriteLine("Seu saldo é:" + saldo); 
        }
    }
}
