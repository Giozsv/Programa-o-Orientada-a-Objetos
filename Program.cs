using ExemploPOO.Helper;
using ExemploPOO.Interfaces;
using ExemploPOO.Modulo;

namespace ExemploPOO
{
    class Progran
    {
        static void Main(string[] args)
        {
            var caminho = "C:\\TrabalhandoComArquivos";
            var caminhoPathCombine = Path.Combine(caminho,"Teste 1");
            var caminhoArquivo = Path.Combine(caminho,"arquivo-teste-stream.txt");
             var caminhoArquivoTeste = Path.Combine(caminho,"arquivo-texte.txt");
             var caminhoArquivoTesteCopia = Path.Combine(caminho,"arquivo-texte-bkp.txt");
            var novoCaminhoArquivo = Path.Combine(caminho, "Teste2", "arquivo-teste-stream.txt");

            var listaString = new List<string> { "Linha 1", "Linha 2", "Linha 3"};
            var listaStringContinuacao = new List<string> { "Linha 4", "Linha 5", "Linha 6" };

            FileHelper helper = new FileHelper();
             helper.ListarArquivosDiretorios(caminho);
             helper.ListarArquivosDiretorios(caminho);  ///COMBINE = AUTOMÁTICO SEM BARRAS = COMBINAÇÃO DE CAMINHO
             System.Console.WriteLine("Criando diretório:" + caminhoPathCombine);
             helper.CriarDiretorio(caminhoPathCombine);
             helper.ApagarDiretorio(caminhoPathCombine, true);
             helper.CriarArquivoTexto(caminhoArquivo, "Olá! Teste de escrita de arquivo");
             helper.CriarArquivoTextoStream(caminhoArquivo, listaString);
             helper.AdicionarTextoStream(caminhoArquivo, listaStringContinuacao);
            helper.LerArquivoStream(caminhoArquivo);
             helper.MoverArquivo(caminhoArquivo, novoCaminhoArquivo);
             helper.CopiandoArquivo(caminhoArquivoTeste, caminhoArquivoTesteCopia, false);
            helper.DeletarArquivo(caminhoArquivoTesteCopia);

            // Implementando Interfaces
             iCalculadora calc = new Calculadora();
             System.Console.WriteLine(calc.Somar(10, 20)); 

            // CLASSES OBJECT 
             Computador comp = new Computador();
             System.Console.WriteLine(comp.ToString()); 
                   
            // CLASSES ABSTRATAS
             Corrente c = new Corrente();
             c.Creditar(100);

             c.ExibirSaldo();


            // POLIMORFISMO EM TEMPO DE COMPILAÇAO
             Calculadora calc = new Calculadora();\\
             System.Console.WriteLine("Resultado da primeira soma: " + calc.Somar(10, 10));
             System.Console.WriteLine("Resultado da segunda soma: " + calc.Somar(10, 10, 10));



            // Polimorfismo em tempo de Execução:
             Aluno p1 = new Aluno();
             p1.Nome = "Bob";
             p1.Idade = 20;
             p1.Documento = "doc.3456";
             p1.Nota = 10;
             p1.Apresentar();

             Professor p2= new Professor();
             p2.Nome = "Bob";
             p2.Idade = 20;
             p2.Documento = "doc.3456";
             p2.Salario = 2000;
             p2.Apresentar();




            // ENCAPSULAMENTO:
             Retangulo r1 = new Retangulo();
             Retangulo r2 = new Retangulo();
             r1.DefinirMedidas(30, 30);
             System.Console.WriteLine($"Área: {r1.ObterArea()}");

              Valores invalidos
             Retangulo r2 = new Retangulo();
             r2.DefinirMedidas(0, 0);
            System.Console.WriteLine($"Área: {r2.ObterArea()}");


            // ABSTRAÇÃO:
             Pessoa p1 = new Pessoa();

             p1.Nome = "Bob";
             p1.Idade = 20;

             p1.Apresentar();
        }
    }
}
