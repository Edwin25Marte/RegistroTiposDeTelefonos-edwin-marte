using Formulario;
using Formulario.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploTodoJunto.Consultas
{
    public partial class tTelefonos : Form
    {
        public tTelefonos()
        {
            InitializeComponent();
        }
        private Estudiante LlenaClase()
        {
            Estudiante p = new Estudiante();

            p.TipoId = int.Parse(TId.Text);
            p.TelDescript = Descript.Text;
            return p;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            Estudiante persona = LlenaClase();

            if (EstudianteBll.Guardar(persona))
                MessageBox.Show("Ha ingresado un telefono!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int TipoId = 0;
            Contexto c = new Contexto();
            int.TryParse(TId.Text, out TipoId);
            var t = c.Persona.Find(TipoId);
            c.Persona.Remove(t);
            c.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Consultas.cTel ct = new Consultas.cTel();
            ct.Show();
        }

        private void tTelefonos_Load(object sender, EventArgs e)
        {

        }
    }
}
