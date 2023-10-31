namespace Core.Entities
{
    public class RolPersona : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Persona> personas { get; set; }
        
    }
}