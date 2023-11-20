namespace ea3_poo1_cesmac.Entities
{
    public class Movie : BaseEntity
    {
        public Movie() { }

        public Movie(string nome, string diretor, string descricao, string genero, int duracaoEmMinutos, bool is3D)
        {
            Nome = nome;
            Diretor = diretor;
            Descricao = descricao;
            Genero = genero;
            DuracaoEmMinutos = duracaoEmMinutos;
            this.is3D = is3D;
        }
        public string Nome { get; set; }
        public string Diretor { get; set; }
        public string Descricao { get; set; }
        public string Genero { get; set; }
        public int DuracaoEmMinutos { get; set; }
        public bool is3D { get; set; }

    }
}
