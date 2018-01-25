using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Formulario
{
    public class Estudiante
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombre { get; set; }
        public int InscripcionID { get; set; }
        public int Monto { get; set; }
        public string Observaciones { get; set; }
        public int Balance { get; set; }
        public int TipoId { get; set; }
        public string TelDescript { get; set; }

        public Estudiante()
        {
            this.EstudianteId = 0;
            this.Nombre = string.Empty;
            this.InscripcionID = 0;
            this.Monto = 0;
            this.Observaciones = string.Empty;
            this.Balance = 0;
            this.TipoId = 0;
            this.TelDescript = string.Empty;
        }

        public Estudiante(int personaId, string nombres, int InscripcionID, int Monto, string Observaciones, int Balance, int TipoId, string TelDescript)
        {
            this.EstudianteId = personaId;
            this.Nombre = nombres;
            this.InscripcionID = InscripcionID;
            this.Monto = Monto;
            this.Observaciones = Observaciones;
            this.Balance = Balance;
            this.TipoId = TipoId;
            this.TelDescript = TelDescript;
        }
    }
}
