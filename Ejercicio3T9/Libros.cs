using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.IO;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using Ejercicio1T9;
using Microsoft.VisualBasic;
using Microsoft.Win32;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio3T9
{
    public partial class Libros : Form
    {
        public Libros()
        {
            InitializeComponent();
        }

        // Instancia del objeto que maneja la BD.
        SqlDBHelper sqlDBHelper;

        // Variable que indica en qué registro estamos situados.
        private int pos;
        private void Form1_Load(object sender, EventArgs e)
        {
            // Creamos el objeto BD
            sqlDBHelper = new SqlDBHelper();
            // Situamos la primera posición
            // y mostramos el registro
            pos = 0;
            mostrarRegistro(pos);
        }
        // Subprograma que muestra el registro situado en la posición pos
        private void mostrarRegistro(int pos)
        {
            Libro libro;
            libro = sqlDBHelper.devuelveLibro(pos);
            // Ponemos los valores en los textBox correspondientes
            tituloTextBox.Text = libro.Titulo;
            autorTextBox.Text = libro.Autor;
            formatoTextBox.Text = libro.Formato;
            idiomaTextBox.Text = libro.Idioma;
            leidoTextBox.Text = libro.Leido;   

            // Inhabilita siguiente, primero, anterior y ultimo si solo tiene un registro o ninguno
            habilitarDesabilitarBotones();
            verNumeroRegistros();
        }
        private void verNumeroRegistros()
        {
            if(sqlDBHelper.NumLibros == 0)
            {
                registroLabel.Text = "0 registros";
            }
            else
            {
                registroLabel.Text = "Registro " + ( pos + 1 ).ToString() + " de " + sqlDBHelper.NumLibros.ToString();
            }
        }

        private void habilitarDesabilitarBotones()
        {
            // TODO: sacar habilitar los botones
            // Activa el botón
            primeroButton.Enabled = true;
            ultimoButton.Enabled = true;
            anteriorButton.Enabled = true;
            siguienteButton.Enabled = true;
            eliminarButton.Enabled = true;
            actualizarButton.Enabled = true;
            guardarButton.Enabled = false;


            if(sqlDBHelper.NumLibros <= 1)
            {
                // Desactiva el botón
                primeroButton.Enabled = false;
                anteriorButton.Enabled = false;
                ultimoButton.Enabled = false;
                siguienteButton.Enabled = false;

                if(sqlDBHelper.NumLibros == 0)
                {
                    guardarButton.Enabled = true;
                    eliminarButton.Enabled = false;
                    actualizarButton.Enabled = false;
                }
            }
            else if(pos == 0)
            {
                // Desactiva el botón
                primeroButton.Enabled = false;
                anteriorButton.Enabled = false;
            }
            else if(pos == sqlDBHelper.NumLibros - 1)
            {
                // Desactiva el botón
                ultimoButton.Enabled = false;
                siguienteButton.Enabled = false;
            }
        }
        private void bPrimero_Click(object sender, EventArgs e)
        {
            // Ponemos la primera posición
            pos = 0;
            mostrarRegistro(pos);
        }
        private void bAnterior_Click(object sender, EventArgs e)
        {
            // Vamos a la posición anterior.
            pos--;
            mostrarRegistro(pos);
        }
        private void bSiguiente_Click(object sender, EventArgs e)
        {
            // Vamos a la posición siguiente
            pos++;
            mostrarRegistro(pos);
        }
        private void bUltimo_Click(object sender, EventArgs e)
        {
            // Vamos a la última posición.
            // Tener en cuenta que los registros van del 0 al numero de registros - 1
            pos = sqlDBHelper.NumLibros - 1;
            mostrarRegistro(pos);
        }
        private void anadirButton_Click(object sender, EventArgs e)
        {
            if(anadirButton.Text == "Cancelar")
            {
                mostrarRegistro(pos);

                // Volvemos a cambiarlo a añadir
                anadirButton.Text = "Añadir";
            }
            else
            {
                tituloTextBox.Clear();
                autorTextBox.Clear();
                formatoTextBox.Clear();
                idiomaTextBox.Clear();
                leidoTextBox.Clear();
                // Habilitar el botón guardar
                guardarButton.Enabled = true;

                // Impedir que pueda hacer nada excepto guardar o cancelar
                primeroButton.Enabled = false;
                anteriorButton.Enabled = false;
                siguienteButton.Enabled = false;
                ultimoButton.Enabled = false;
                eliminarButton.Enabled = false;
                actualizarButton.Enabled = false;

                // Cambiar nombre del botón de añadir a cancelar
                anadirButton.Text = "Cancelar";
            }

        }
        private void guardarButton_Click(object sender, EventArgs e)
        {
            if(tituloTextBox.Text != "" && autorTextBox.Text != "" && formatoTextBox.Text != "" && idiomaTextBox.Text != "" && leidoTextBox.Text != "")
            {
                if(!sqlDBHelper.estaTituloDuplicado(tituloTextBox.Text))
                {
                    // Creamos el profesor con los datos del formulario
                    Libro libro = new Libro(tituloTextBox.Text, autorTextBox.Text, formatoTextBox.Text, idiomaTextBox.Text, leidoTextBox.Text);
                    sqlDBHelper.anadirLibro(libro);
                    // Actualizamos la posición
                    pos = sqlDBHelper.NumLibros - 1;

                    // Volvemos a cambiarlo a añadir
                    anadirButton.Text = "Añadir";

                    mostrarRegistro(pos);
                }
            }

        }
        
        private void actualizarButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Quiere actualizar el registro?", "Cambio", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                // Creamos el profesor con los datos del formulario
                Libro libro = new Libro(tituloTextBox.Text, autorTextBox.Text, formatoTextBox.Text, idiomaTextBox.Text, leidoTextBox.Text);
                sqlDBHelper.actualizarLibro(libro, pos);
            }

        }
       
        private void eliminarButton_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Estas seguro que quiere eliminar el registro actual?", "Eliminar", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                sqlDBHelper.eliminarProfesor(pos);
                // Nos vamos al primer registro y lo mostramos
                pos = 0;
                mostrarRegistro(pos);
            }
        }

        private void listaProfesoresButton_Click(object sender, EventArgs e)
        {
            sqlDBHelper.listaLibros();
        }

        private void buscarApellidoButton_Click(object sender, EventArgs e)
        {
            pos = sqlDBHelper.buscarLibros(pos);
            //pos = posicionEncontrada;
            mostrarRegistro(pos);
        }
    }
    
}

