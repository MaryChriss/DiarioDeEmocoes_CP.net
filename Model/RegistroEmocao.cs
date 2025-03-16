namespace DiarioEmocoes_webapi.Models
{
    public class RegistroEmocao : BaseEntity
    {
        public string Emocao { get; private set; }
        public string Comentario { get; private set; }
        public string Categoria { get; private set; }
        public int Importancia { get; private set; }
        public string Tag { get; private set; }

        public RegistroEmocao(string emocao, string comentario)
        {
            if (string.IsNullOrWhiteSpace(emocao))
                throw new ArgumentException("A emoção não pode ser vazia.");

            if (string.IsNullOrWhiteSpace(comentario))
                throw new ArgumentException("O comentário não pode ser vazio.");

            Id = DiarioEmocoes_webapi.Utils.IdGenerator.GerarNovoId(); // Usando o nível internal
            Emocao = emocao;
            Comentario = comentario;
            Categoria = "Pessoal";
            Importancia = 1;
            Tag = "Emoção";
        }

        // Método protected internal - acessível de classes derivadas e de dentro do assembly
        protected internal void MostrarCategoria()
        {
            Console.WriteLine($"Categoria: {Categoria}");
        }

        // Método private protected - acessível apenas por classes derivadas dentro do mesmo assembly
        private protected void MostrarTag()
        {
            Console.WriteLine($"Tag: {Tag}");
        }

        public override string ToString()
        {
            return $"Emoção: {Emocao}\nComentário: {Comentario}\nData: {Data}\nCategoria: {Categoria}";
        }
    }
}
