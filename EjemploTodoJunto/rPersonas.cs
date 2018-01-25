using EjemploTodoJunto.Consultas;
using Formulario.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class rPersonas : Form
    {
        public rPersonas()
        {
            InitializeComponent();
        }

        private Estudiante LlenaClase()
        {
            Estudiante p = new Estudiante();

            p.InscripcionID = int.Parse(InscIdTextBox.Text);
            p.EstudianteId = int.Parse(EstIdTextBox.Text);
            p.Nombre = NombrestextBox.Text;
            p.Monto = int.Parse(MontotextBox.Text);
            p.Balance = int.Parse(BalancetextBox.Text);
            p.Observaciones = ObservacionestextBox.Text;
           // p.TipoId = int.Parse(TId.Text);
           // p.TelDescript = Descript.Text;
            return p;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Estudiante persona = LlenaClase();

            if (EstudianteBll.Guardar(persona))
                MessageBox.Show("Ha ingresado un Estudiante!");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Consultas.cEstudiante cpersonas = new Consultas.cEstudiante();
            cpersonas.Show();
        }

        private void rPersonas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tTelefonos cet = new tTelefonos();
            cet.Show();
        }
    }
}
