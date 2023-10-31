namespace Core.Entities
{
    public class Inventario : BaseEntity
    {
        public string Nombre { get; set; }
        public string CodProducto { get; set; }
        public decimal Precio { get; set; }
        public short Stock { get; set; }
        public short StockMin { get; set; }
        public short StockMax { get; set; }
        public int IdPresentacion { get; set; }
        public ICollection<DetalleMovimientoInventario> detallesMovimientosInventarios { get; set; }
        public Producto producto { get; set; }
        public Presentacion presentacion { get; set; }
        
    }
}