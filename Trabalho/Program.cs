using System;

namespace TrabalhoADS
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeAluno = "Vladimir Jesús Taype Quispe";
            string raAluno = "R1190B0";

            // Cria um objeto (instância) da classe AlunoAds
            AlunoAds aluno = new AlunoAds(nomeAluno, raAluno, "Análise e Desenvolvimento de Sistemas", 3);

            // Pede ao usuário para informar o RA
            Console.WriteLine("Por favor, digite o seu RA para validação:");
            string raInformado = Console.ReadLine()!;

            // Usa o método ValidarRa para verificar o RA
            if (aluno.ValidarRa(raInformado))
            {
                // Se o RA for válido, exibe a mensagem completa
                Console.WriteLine(aluno.InformarStatus());
            }
            else
            {
                // Se o RA for inválido, exibe uma mensagem de erro
                Console.WriteLine("RA inválido. Por favor, tente novamente.");
            }

            // Aguarda o usuário pressionar uma tecla para fechar
            Console.ReadKey();
        }
    }
}
