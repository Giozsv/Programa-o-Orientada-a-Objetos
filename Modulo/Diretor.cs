namespace ExemploPOO.Modulo
{
    public class Diretor : Professor
    {
        public override void Apresentar()
        {
            Console.WriteLine($"Diretor");
        }
    }  
}
/// Método selado não funciona com níveis de classes abaixo de classes filhas
// selead = significa que não se pretende deixar-se derivado de classes filhas
//mas travar o comportamento em uma classe pai.
