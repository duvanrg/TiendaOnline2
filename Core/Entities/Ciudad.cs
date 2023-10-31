using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;
public class Ciudad : BaseEntity
{
    public string Nombre { get; set; }
    public int idDepartamentoFk { get; set; }
    public Departamento Departamentos { get; set; }
    public ICollection<UbicacionPersona> ubicacionesPersonas { get; set; }

}
