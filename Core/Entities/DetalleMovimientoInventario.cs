namespace Core.Entities
{
    public class DetalleMovimientoInventario : BaseEntity
    {
        public int IdInventario { get; set; }
        public int IdMovInv { get; set; }
        public short Cantidad { get; set; }
        public double Precio { get; set; }
    }
}