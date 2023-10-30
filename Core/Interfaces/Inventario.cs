namespace Core.Interfaces
{
    public class IInventario
    {
    
    public string CodProducto { get; set; }
    public decimal Precio { get; set; }
    public short Stock { get; set; }
    public short StockMin { get; set; }
    public short StockMax { get; set; }
    public int IdPresentacion { get; set; }
    }
}