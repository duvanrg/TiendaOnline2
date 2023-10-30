namespace Core.Entities
{
    public class Persona : BaseEntity
    {
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdDocumento { get; set; }
        public int IdRolPersona { get; set; }
        public int IdTipoPersona { get; set; }
    }
}