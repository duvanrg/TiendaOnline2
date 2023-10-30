namespace API.Dtos
{
    public class Inventario 
    { 
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string CodProducto { get; set; }
    public decimal Precio { get; set; }
    public short Stock { get; set; }
    public short StockMin { get; set; }
    public short StockMax { get; set; }
    public int IdPresentacion { get; set; }
    }
}