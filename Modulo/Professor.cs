namespace ExemploPOO.Modulo
{
    public class Professor : Pessoa
    {
        public double Salario { get; set; }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um Professor que ganha {Salario}");
        }
    }
}
