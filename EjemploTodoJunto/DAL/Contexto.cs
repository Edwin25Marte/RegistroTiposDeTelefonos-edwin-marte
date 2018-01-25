using System;
using System.Data.Entity;

namespace Formulario
{
    /// <summary>
    /// Esta clase es el contexto que nos permite conectarnos a la base de datos
    /// Solo necesitamos crear las entidades con las que interactuaremos
    /// Ademas hay que indicarle el conexion string que permite llegar a la data
    /// </summary>
    public class Contexto : DbContext
    {
        public DbSet<Estudiante> Persona { get; set; }

        public Contexto() : base("ConStr")
        {

        }
    }


}
