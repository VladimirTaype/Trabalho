namespace TrabalhoADS
{
    // A classe AlunoAds herda da classe Aluno
    public class AlunoAds : Aluno
    {
        // Propriedades específicas da classe filha
        public string Curso { get; set; }
        public int Semestre { get; set; }

        // Construtor que usa o construtor da classe base (base)
        public AlunoAds(string nome, string ra, string curso, int semestre) : base(nome, ra)
        {
            Curso = curso;
            Semestre = semestre;
        }

        // Método para gerar a mensagem completa
        public string InformarStatus()
        {
            return $"Este RA pertence ao aluno {Nome} que está cursando o {Semestre}º semestre do curso de {Curso}.";
        }
    }
}