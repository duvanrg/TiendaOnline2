namespace Core.Entities
{
    public class Producto : BaseEntity
    {
        public string NombreProd { get; set; }
        public int IdMarca { get; set; }
        public ICollection<Inventario> inventarios { get; set; }
        public Marca marca { get; set; }
    }
}