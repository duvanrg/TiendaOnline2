namespace Core.Entities
{
    public class Persona : BaseEntity
    {
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdDocumento { get; set; }
        public int IdRolPersona { get; set; }
        public int IdTipoPersona { get; set; }
        public ICollection<MovimientoInventario> movimientoInventariosReceptor { get; set; }
        public ICollection<MovimientoInventario> movimientoInventariosResponsable { get; set; }
        public ICollection<UbicacionPersona> ubicacionesPersonas { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public RolPersona rolPersona { get; set; }
        public TipoPersona tipoPersona { get; set; }
    }
}