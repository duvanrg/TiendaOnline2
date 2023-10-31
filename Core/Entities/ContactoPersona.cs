namespace Core.Entities
{
    public class ContactoPersona : BaseEntity
    {
        public int IdPersona { get; set; }
        public int IdTipoContacto { get; set; }
        public Persona persona { get; set; }
        public TipoContacto tipoContacto { get; set; }
    }
}