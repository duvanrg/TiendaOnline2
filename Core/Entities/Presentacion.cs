namespace Core.Entities
{
    public class Presentacion : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Producto> productos { get; set; }
    }
}