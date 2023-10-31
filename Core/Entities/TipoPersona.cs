namespace Core.Entities
{
    public class TipoPersona : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Persona> personas { get; set; }

    }
}