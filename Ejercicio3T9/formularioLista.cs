using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1T9
{
    public partial class formularioLista : Form
    {
        public formularioLista()
        {
            InitializeComponent();
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();

            ordenarComboBox.Text = string.Empty;
            idiomacomboBox.Text = string.Empty;
            leidoComboBox.Text = string.Empty;
            formatoComboBox.Text = string.Empty;

            Resultadolabel.Text = sqlDBHelper.listaLibros();
        }

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;
   

            private void Resultadolabel_Click(object sender, EventArgs e)
        {


        }
    }
}
