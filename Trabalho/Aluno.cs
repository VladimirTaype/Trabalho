namespace TrabalhoADS
{
    public class Aluno
    {
        // Propriedades para armazenar os dados
        public string Nome { get; set; }
        public string Ra { get; set; }

        // Construtor para inicializar as propriedades
        public Aluno(string nome, string ra)
        {
            Nome = nome;
            Ra = ra;
        }

        // Método para validar se o RA informado é o mesmo
        public bool ValidarRa(string raInformado)
        {
            return Ra == raInformado;
        }
    }
}