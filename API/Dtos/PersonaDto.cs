namespace API.Dtos
{
    public class Persona
    {
        public int Id {get; set;}
        public string Nombre { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdDocumento { get; set; }
        public int IdRolPersona { get; set; }
        public int IdTipoPersona { get; set; }
    }
}