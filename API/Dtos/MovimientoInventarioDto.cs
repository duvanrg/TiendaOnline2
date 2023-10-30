namespace API.Dtos
{
    public class MovimientoInventario
    {
        public int Id {get; set;}
        public int IdResponsable { get; set; }
        public int IdReceptor { get; set; }
        public int IdTipoMovimientoInventario { get; set; }
        public int IdFormaPago { get; set; }
        public DateTime FechaMovimiento { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}