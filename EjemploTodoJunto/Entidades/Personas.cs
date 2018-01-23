using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Formulario
{
    public class Personas
    {
        [Key]//Es obligatorio indicar cual es la clave primaria de la entidad
        public int PersonaId { get; set; }
        public string Nombre { get; set; }
        public int InscripcionID { get; set; }
        public int Monto { get; set; }
        public string Observaciones { get; set; }
        public int Balance { get; set; }

        public Personas()
        {
            this.PersonaId = 0;
            this.Nombre = string.Empty;
            this.InscripcionID = 0;
            this.Monto = 0;
            this.Observaciones = string.Empty;
            this.Balance = 0;
        }

        public Personas(int personaId, string nombres, int InscripcionID, int Monto, string Observaciones, int Balance)
        {
            this.PersonaId = personaId;
            this.Nombre = nombres;
            this.InscripcionID = InscripcionID;
            this.Monto = Monto;
            this.Observaciones = Observaciones;
            this.Balance = Balance;
        }
    }
}
