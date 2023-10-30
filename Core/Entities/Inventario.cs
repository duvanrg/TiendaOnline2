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
    }
}