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

        private Personas LlenaClase()
        {
            Personas p = new Personas();

            p.InscripcionID = int.Parse(InscIdTextBox.Text);
            p.EstudianteId = int.Parse(EstIdTextBox.Text);
            p.Nombre = NombrestextBox.Text;
            p.Monto = int.Parse(MontotextBox.Text);
            p.Balance = int.Parse(BalancetextBox.Text);
            p.Observaciones = ObservacionestextBox.Text;
            p.TipoId = int.Parse(TId.Text);
            p.TelDescript = Descript.Text;
            return p;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Personas persona = LlenaClase();

            if (PersonasBll.Guardar(persona))
                MessageBox.Show("Ha ingresado un Estudiante!");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            Consultas.cPersonas cpersonas = new Consultas.cPersonas();
            cpersonas.Show();
        }

        private void rPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
