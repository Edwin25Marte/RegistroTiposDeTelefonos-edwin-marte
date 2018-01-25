using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Formulario.BLL
{
    public class EstudianteBll
    {
        public static bool Guardar(Estudiante persona)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Persona.Add(persona);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static bool Modificar(Estudiante persona)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                contex.Entry(persona).State = EntityState.Modified;
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;

        }

        public static bool Eliminar(int personaId)
        {
            bool paso = false;

            try
            {
                Contexto contex = new Contexto();

                var persona = contex.Persona.Find(personaId);

                contex.Persona.Remove(persona);
                contex.SaveChanges();

                paso = true;
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Estudiante Buscar(int personaId)
        {
            Estudiante persona = new Estudiante();

            try
            {
                Contexto contex = new Contexto();
                persona = contex.Persona.Find(personaId);
            }
            catch (Exception)
            {
                throw;
            }

            return persona;
        }

        public static List<Estudiante> GetList (Expression<Func<Estudiante, bool>> criterioBusqueda)
        {
            List<Estudiante> personas = new List<Estudiante>();
            try
            {
                Contexto contex = new Contexto();
                personas= contex.Persona.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return personas;
        }

    }
}