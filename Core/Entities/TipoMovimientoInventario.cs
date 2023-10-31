namespace Core.Entities
{
    public class TipoMovimientoInventario : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<MovimientoInventario> movimientosInventarios { get; set; }
        
    }
}