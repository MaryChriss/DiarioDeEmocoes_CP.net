namespace DiarioEmocoes_webapi.DiarioLib.obj
{
    public class RegistroEmocao : BaseEntity
    {
        public string Emoção { get; set; }

        private string Comentario { get; set; }

        protected internal string Categoria { get; set; }

        private protected int Importancia { get; set; }

        private string Tag { get; set; } = "Emoção";

        public RegistroEmocao(int id, string emoção, string comentario)
        {
            Id = id;
            Emoção = emoção;
            Comentario = comentario;
            Categoria = "Pessoal";
            Importancia = 1;
        }

        public override string ToString()
        {
            return $" Emoção: {Emoção}\n Comentário: {Comentario}\n Data: {Data}\n Categoria: {Categoria}";
        }
    }
}
