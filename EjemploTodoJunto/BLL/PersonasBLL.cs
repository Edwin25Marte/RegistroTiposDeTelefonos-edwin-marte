using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Formulario.BLL
{
    public class PersonasBll
    {
        public static bool Guardar(Personas persona)
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

        public static bool Modificar(Personas persona)
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

        public static Personas Buscar(int personaId)
        {
            Personas persona = new Personas();

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

        public static List<Personas> GetList (Expression<Func<Personas, bool>> criterioBusqueda)
        {
            List<Personas> personas = new List<Personas>();
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