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
        }

        private void formularioLista_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();

            Resultadolabel.Text = sqlDBHelper.listaLibros();
        }

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;        

        private void todosButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibros();
        }

        private void castellanoButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibrosIdioma("Castellano");

        }

        private void inglesButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibrosIdioma("Inglés");
        }

        private void siButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibrosLeido("Sí");

        }

        private void noButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibrosLeido("No");

        }

        private void fisicoButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibrosFormato("Físico");

        }

        private void digitalButton_Click(object sender, EventArgs e)
        {
            Resultadolabel.Text = sqlDBHelper.listaLibrosFormato("Digital");
        }
    }
}
