namespace DiarioEmocoes_webapi.DiarioLib.obj
{
    public abstract class BaseEntity
    {
        internal int Id { get; set; }

        protected DateTime Data { get; set; }

        public BaseEntity()
        {
            Data = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[ID: {Id}] - Data: {Data}";
        }
    }
}
