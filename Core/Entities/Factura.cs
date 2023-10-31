namespace Core.Entities
{
    public class Factura : BaseEntity
    {
        public int FacturaInicial { get; set; }
        public int FacturaActual { get; set; }
        public int FacturaFinal { get; set; }
        public string NroResolucion { get; set; }
    }
}