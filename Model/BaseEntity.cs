namespace DiarioEmocoes_webapi.Models
{
    public abstract class BaseEntity
    {
        protected int Id { get; set; }
        public DateTime Data { get; protected set; }

        public BaseEntity()
        {
            Data = DateTime.Now;
        }

        protected void MostrarData()
        {
            Console.WriteLine($"Data: {Data}");
        }

        public override string ToString()
        {
            return $"[ID: {Id}] - Data: {Data}";
        }
    }
}
