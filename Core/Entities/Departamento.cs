using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Departamento: BaseEntity
    {
        public string Nombre { get; set; }
        public Pais paises { get; set; }
    }
}