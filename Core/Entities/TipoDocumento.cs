namespace Core.Entities
{
    public class TipoDocumento : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Persona> personas { get; set; }
        
    }
}