using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ejercicio_3.Models
{
    public class CRUD
    {
        public static List<Alumno> Alumnos { get; } = new List<Alumno>();
        public static List<Maestria> Maestrias { get; } = new List<Maestria>();
        public static List<Docente> Docentes { get; } = new List<Docente>();
        public static List<Universidad> Universidads { get; } = new List<Universidad>();
        public static List<Maestria_Imparte_Docente> Maestria_Imparte_Docentes { get; } = new List<Maestria_Imparte_Docente>();
        public static List<Universidad_Tiene_Docente> Universidad_Tiene_Docentes { get; } = new List<Universidad_Tiene_Docente>();

        //CRUD para la tabla Alumno---------------------------------------------------------------------

        public static void agregarAlumno(Alumno a)
        {
            if (Alumnos.Count > 0)
            {
                a.CURP_Alumno = Alumnos.Count;
            }
            else if (Alumnos.Count == 0)
            {
                a.CURP_Alumno = 0;
            }

            Alumnos.Add(a);
        }

        //CRUD para la tabla Maestria---------------------------------------------------------------------

        public static void agregarMaestria(Maestria m)
        {
            if (Maestrias.Count > 0)
            {
                m.Id_Maestria = Maestrias.Count;
            }
            else if (Maestrias.Count == 0)
            {
                m.Id_Maestria = 0;
            }

            Maestrias.Add(m);
        }

        //CRUD para la tabla Docente---------------------------------------------------------------------

        public static void agregarDocente(Docente d)
        {
            if (Docentes.Count > 0)
            {
                d.Id_Docente = Docentes.Count;
            }
            else if (Docentes.Count == 0)
            {
                d.Id_Docente = 0;
            }

            Docentes.Add(d);
        }

        //CRUD para la tabla Universidad---------------------------------------------------------------------

        public static void agregarUniversidad(Universidad u)
        {
            if (Universidads.Count > 0)
            {
                u.Id_Universidad = Universidads.Count;
            }
            else if (Universidads.Count == 0)
            {
                u.Id_Universidad = 0;
            }

            Universidads.Add(u);
        }

        //CRUD para la tabla Maestria_Imparte_Docente---------------------------------------------------------------------

        public static void agregarMaestria_Imparte_Docente(Maestria_Imparte_Docente md, string nom_maestria, string nom_docente)
        {
            if (Maestria_Imparte_Docentes.Count > 0)
            {
                md.Id_Maestria_Docente = Maestria_Imparte_Docentes.Count;
            }
            else if (Maestria_Imparte_Docentes.Count == 0)
            {
                md.Id_Maestria_Docente = 0;
            }

            md.Nombre_Maestria = nom_maestria;
            md.Nombre_Docente = nom_docente;

            Maestria_Imparte_Docentes.Add(md);
        }

        //CRUD para la tabla Universidad_Tiene_Docente---------------------------------------------------------------------

        public static void agregarUniversidad_Tiene_Docente(Universidad_Tiene_Docente ud, string nom_universidad, string nom_docente)
        {
            if (Universidad_Tiene_Docentes.Count > 0)
            {
                ud.Id_Universidad_Docente = Universidad_Tiene_Docentes.Count;
            }
            else if (Universidad_Tiene_Docentes.Count == 0)
            {
                ud.Id_Universidad_Docente = 0;
            }

            ud.Nombre_Universidad = nom_universidad;
            ud.Nombre_Docente = nom_docente;

            Universidad_Tiene_Docentes.Add(ud);
        }

    }
}
