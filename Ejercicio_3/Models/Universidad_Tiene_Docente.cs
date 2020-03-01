using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class Universidad_Tiene_Docente
    {
        public int Id_Universidad_Docente { get; set; }
        public int Id_Universidad { get; set; }
        public string Nombre_Universidad { get; set; }
        public int Id_Docente { get; set; }
        public string Nombre_Docente { get; set; }
    }
}
