namespace Core.Entities
{
    public class TipoContacto : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<ContactoPersona> contactosPersonas { get; set; }
    }
}