using Formulario.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulario.Consultas
{
    public partial class cEstudiante : Form
    {
        public cEstudiante()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                int id = 0;
                int.TryParse(CriteriotextBox.Text, out id);

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.InscripcionID == id);
            }

            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                
                String s = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.Nombre == s);
            }
            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                int esId = 0;
                int.TryParse(CriteriotextBox.Text, out esId);

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.EstudianteId == esId);
            }

            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                
                int monto = 0;
                int.TryParse(CriteriotextBox.Text, out monto);

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.Monto == monto);
            }

            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                
                int balance = 0;
                int.TryParse(CriteriotextBox.Text, out balance);

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.Balance == balance);
            }

            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                String Obser = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.Observaciones == Obser);
            }
            if (FiltrarcomboBox.SelectedIndex == 6)
            {
                int Tid = 0;
                int.Parse(CriteriotextBox.Text);

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.TipoId == Tid);
            }
            if (FiltrarcomboBox.SelectedIndex == 7)
            {

                String des = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.TelDescript == des);
            }
        }

        private void cPersonas_Load(object sender, EventArgs e)
        {

        }
    }
}
