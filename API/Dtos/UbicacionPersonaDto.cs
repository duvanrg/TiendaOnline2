namespace Core.Entities
{
    public class UbicacionPersona : BaseEntity
    {
        public string TipoDeVia { get; set; }
        public short NumeroPri { get; set; }
        public string Letra { get; set; }
        public string Bis { get; set; }
        public string LetraSec { get; set; }
        public string Cardinal { get; set; }
        public short NumeroSec { get; set; }
        public string LetraTer { get; set; }
        public short NumeroTer { get; set; }
        public string CardinalSec { get; set; }
        public string Complemento { get; set; }
        public string IdPersona { get; set; }
        public int IdCiudad { get; set; }
    }

}