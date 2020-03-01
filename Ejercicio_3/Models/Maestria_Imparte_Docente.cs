using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class Maestria_Imparte_Docente
    {
        public int Id_Maestria_Docente { get; set; }
        public int Id_Maestria { get; set; }
        public string Nombre_Maestria { get; set; }
        public int Id_Docente { get; set; }
        public string Nombre_Docente { get; set; }

    }
}
