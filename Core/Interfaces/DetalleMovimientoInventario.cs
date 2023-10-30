namespace Core.Interfaces
{
    public class IDetalleMovimientoInventario
    {
        public int IdInventario { get; set; }
        public int IdMovInv { get; set; }
        public short Cantidad { get; set; }
        public double Precio { get; set; }
    }
}