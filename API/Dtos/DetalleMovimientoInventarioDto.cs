namespace API.Dtos
{
    public class DetalleMovimientoInventario
    {
        public int Id {get; set;}
        public int IdInventario { get; set; }
        public int IdMovInv { get; set; }
        public short Cantidad { get; set; }
        public double Precio { get; set; }
    }
}