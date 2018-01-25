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
    public partial class cTel : Form
    {
        public cTel()
        {
            InitializeComponent();
        }

        private void cTel_Load(object sender, EventArgs e)
        {

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                int id = 0;
                int.TryParse(CriteriotextBox.Text, out id);

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.TipoId == id);
            }

            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                
                String s = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = EstudianteBll.GetList(es => es.TelDescript == s);
            }
        }
    }
}
