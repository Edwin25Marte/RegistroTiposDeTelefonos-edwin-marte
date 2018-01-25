using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EjemploTodoJunto.Entidades
{
    public class Reg_Tipos
    {
        public int TipoId { get; set; }
        public string TelDescript { get; set; }

        public Reg_Tipos()
        {
            TipoId = 0;
            TelDescript = string.Empty;
        }

        public Reg_Tipos(int TipoId, string TelDescript)
        {
            this.TipoId = TipoId;
            this.TelDescript = TelDescript;
        }
    }
}
