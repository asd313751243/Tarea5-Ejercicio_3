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

        public static void actualizarAlumno(Alumno a, int id)
        {
            Alumnos[id].Nombre_Alumno = a.Nombre_Alumno;
            Alumnos[id].Boleta_Alumno = a.Boleta_Alumno;
            Alumnos[id].Fecha_Nac_Alumno = a.Fecha_Nac_Alumno;
        }

        public static void eliminarAlumno(int id)
        {
            Alumnos.RemoveAt(id);
        }

        public static bool evaluarParaeliminarAlumno(int id)
        {
            bool nope = true;
            foreach (var item in Maestrias)
            {
                if (id == item.CURP_Alumno)
                {
                    nope = false;

                }
            }
            return nope;
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

        public static void actualizarMaestria(Maestria m, int id)
        {
            Maestrias[id].Nombre_Maestria = m.Nombre_Maestria;
            Maestrias[id].Duracion_Mes_Maestria = m.Duracion_Mes_Maestria;
            Maestrias[id].CURP_Alumno = m.CURP_Alumno;
        }

        public static void eliminarMaestria(int id)
        {
            Maestrias.RemoveAt(id);
        }

        public static bool evaluarParaeliminarMaestria(int id)
        {
            bool nope = true;
            foreach (var item in Maestria_Imparte_Docentes)
            {
                if (id == item.Id_Maestria)
                {
                    nope = false;

                }
            }
            return nope;
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

        public static void actualizarDocente(Docente d, int id)
        {
            Docentes[id].Nombre_Docente = d.Nombre_Docente;
            Docentes[id].Tele_Docente = d.Tele_Docente;
        }

        public static void eliminarDocente(int id)
        {
            Docentes.RemoveAt(id);
        }

        public static bool evaluarParaeliminarDocente(int id)
        {
            bool nope = true;
            foreach (var item in Maestria_Imparte_Docentes)
            {
                if (id == item.Id_Docente)
                {
                    nope = false;

                }
            }

            foreach (var item in Universidad_Tiene_Docentes)
            {
                if (id == item.Id_Docente)
                {
                    nope = false;

                }
            }

            return nope;
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

        public static void actualizarUniversidad(Universidad u, int id)
        {
            Universidads[id].Nombre_Universidad = u.Nombre_Universidad;
        }

        public static void eliminarUniversidad(int id)
        {
            Universidads.RemoveAt(id);
        }

        public static bool evaluarParaeliminarUniversidad(int id)
        {
            bool nope = true;
            foreach (var item in Universidad_Tiene_Docentes)
            {
                if (id == item.Id_Universidad)
                {
                    nope = false;

                }
            }
            return nope;
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

        public static void actualizarMaestria_Imparte_Docente(Maestria_Imparte_Docente md, int id, string nom_maestria, string nom_docente)
        {
            Maestria_Imparte_Docentes[id].Id_Maestria = md.Id_Maestria;
            Maestria_Imparte_Docentes[id].Id_Docente = md.Id_Docente;
            Maestria_Imparte_Docentes[id].Nombre_Maestria = nom_maestria;
            Maestria_Imparte_Docentes[id].Nombre_Docente = nom_docente;
        }

        public static void eliminarMaestria_Imparte_Docente(int id)
        {
            Maestria_Imparte_Docentes.RemoveAt(id);
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

        public static void actualizarUniversidad_Tiene_Docente(Universidad_Tiene_Docente ud, int id, string nom_universidad, string nom_docente)
        {
            Universidad_Tiene_Docentes[id].Id_Universidad = ud.Id_Universidad;
            Universidad_Tiene_Docentes[id].Id_Docente = ud.Id_Docente;
            Universidad_Tiene_Docentes[id].Nombre_Universidad = nom_universidad;
            Universidad_Tiene_Docentes[id].Nombre_Docente = nom_docente;
        }

        public static void eliminarUniversidad_Tiene_Docente(int id)
        {
            Universidad_Tiene_Docentes.RemoveAt(id);
        }

    }
}
