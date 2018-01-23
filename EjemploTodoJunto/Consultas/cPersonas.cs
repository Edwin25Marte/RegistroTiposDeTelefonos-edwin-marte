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
    public partial class cPersonas : Form
    {
        public cPersonas()
        {
            InitializeComponent();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (FiltrarcomboBox.SelectedIndex == 0)
            {
                //ponerlo en una funcion
                int id = 0;
                int.TryParse(CriteriotextBox.Text, out id);

                PersonasdataGridView.DataSource = PersonasBll.GetList(es => es.InscripcionID == id);
            }

            if (FiltrarcomboBox.SelectedIndex == 1)
            {
                
                String s = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = PersonasBll.GetList(es => es.Nombre == s);
            }

            if (FiltrarcomboBox.SelectedIndex == 2)
            {
                
                String s = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = PersonasBll.GetList(es => es.Nombre == s);
            }

            if (FiltrarcomboBox.SelectedIndex == 3)
            {
                
                int monto = 0;
                int.TryParse(CriteriotextBox.Text, out monto);

                PersonasdataGridView.DataSource = PersonasBll.GetList(es => es.Monto == monto);
            }

            if (FiltrarcomboBox.SelectedIndex == 4)
            {
                
                int balance = 0;
                int.TryParse(CriteriotextBox.Text, out balance);

                PersonasdataGridView.DataSource = PersonasBll.GetList(es => es.Monto == balance);
            }

            if (FiltrarcomboBox.SelectedIndex == 5)
            {
                
                String s = CriteriotextBox.Text;

                PersonasdataGridView.DataSource = PersonasBll.GetList(es => es.Observaciones == s);
            }
        }
    }
}
