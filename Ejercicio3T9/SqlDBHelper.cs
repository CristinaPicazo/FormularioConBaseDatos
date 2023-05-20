using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Ejercicio3T9;
using System.IO;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio1T9
{
    internal class SqlDBHelper
    {
        private void metodoPath()
        {
            string relative = @"..\..\";
            string absolute = Path.GetFullPath(relative);

            AppDomain.CurrentDomain.SetData("DataDirectory", absolute);
        }

        // Miembros para guardar el dataSet y el dataAdapter de profesores.
        private DataSet dsLibros;
        private SqlDataAdapter daLibros;
        
        // Miembro para guardar el número de profesores.
        private int numLibros;
       
        // Propiedad de solo lectura.
        public int NumLibros
        {
            get => numLibros;
        }

        // Constructor del objeto.
        // En el mismo hacemos la conexión y creamos dataSet y dataAdapter
        public SqlDBHelper()
        {
            metodoPath();
            //string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Instituto.mdf;Integrated Security=True;Connect Timeout=30";
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AppData\\Libros.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);
            
            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From Libros";
            daLibros = new SqlDataAdapter(cadenaSQL, con);
            dsLibros = new DataSet();
            daLibros.Fill(dsLibros, "Libros");
            
            // Obtenemos el número de profesores
            numLibros = dsLibros.Tables["Libros"].Rows.Count;
            
            // Cerramos la conexión.
            con.Close();
        }

        // Método que a partir de una posición en la BD
        // Devuelve un objeto profesor.
        // Devuelve null si pos está fuera de los límites
        public Libro devuelveLibro(int pos)
        {
            Libro libro = null;
            if(pos >= 0 && pos < numLibros)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla Profesores
                dRegistro = dsLibros.Tables["Libros"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y lo creamos el objeto profesor con esos datos.
                libro = new Libro(
                    dRegistro["Titulo"].ToString(), 
                    dRegistro["Autor"].ToString(),
                    dRegistro["Formato"].ToString(), 
                    dRegistro["Idioma"].ToString(),
                    dRegistro["Leido"].ToString()
                );
            }
            return libro;
        }
        
        // Metodos CRUD
        // Método que añade un profesor a nuestra BD
        public void anadirLibro(Libro libro)
        {
            // Creamos un nuevo registro.
            DataRow dRegistro = dsLibros.Tables["Libros"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro["Titulo"] = libro.Titulo;
            dRegistro["Autor"] = libro.Autor;
            dRegistro["Formato"] = libro.Formato;
            dRegistro["Idioma"] = libro.Idioma;
            dRegistro["Leido"] = libro.Leido;
            
            // Añadimos el registro al Dataset
            dsLibros.Tables["Libros"].Rows.Add(dRegistro);

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daLibros);
            daLibros.Update(dsLibros, "Libros");

            // Actualizamos el número de profesores
            numLibros++;

        }

        public void actualizarLibro(Libro libro, int pos)
        {
            // Cogemos el registro situado en la posición actual.
            DataRow dRegistro = dsLibros.Tables["Libros"].Rows[pos];
            // Metemos los datos en el registro
            dRegistro["Titulo"] = libro.Titulo;
            dRegistro["Autor"] = libro.Autor;
            dRegistro["Formato"] = libro.Formato;
            dRegistro["Idioma"] = libro.Idioma;
            dRegistro["Leido"] = libro.Leido;

            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daLibros);
            daLibros.Update(dsLibros, "Libros");
        }
        public void eliminarProfesor(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dsLibros.Tables["Libros"].Rows[pos].Delete();
            
            // Tenemos un profesor menos
            numLibros--;
            
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daLibros);
            daLibros.Update(dsLibros, "Libros");
        }

        public bool estaTituloDuplicado(string titulo)
        {
            for(int i = 0; i < numLibros; i++)
            {
                if(dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString().ToLower() == titulo.ToLower())
                {
                    MessageBox.Show("Titulo duplicado");
                    return true;
                }

            }
            return false;
        }

        public bool cambiosEnTexto(int pos,string titulo, string autor, string formato, string idioma, string leido)
        {
            if(dsLibros.Tables["Libros"].Rows[pos]["Titulo"].ToString() != titulo ||
                dsLibros.Tables["Libros"].Rows[pos]["Autor"].ToString() != autor ||
                dsLibros.Tables["Libros"].Rows[pos]["Formato"].ToString() != formato ||
                dsLibros.Tables["Libros"].Rows[pos]["Idioma"].ToString() != idioma ||
                dsLibros.Tables["Libros"].Rows[pos]["Leido"].ToString() != leido
                    )
            {
                return true;
            }

            return false;
        }

        public string listaLibros()
        {
            string listaLibros = "Libros:";
            if(numLibros > 0)
            {

                for(int i = 0; i < numLibros; i++)
                {
                    listaLibros += "\n"+(i+1)+": " + dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString() + " de " 
                        + dsLibros.Tables["Libros"].Rows[i]["Autor"].ToString();
                }
                return listaLibros;
            }
            else
            {
                return listaLibros="No tiene libros.";
            }
        }

        public int buscarLibros(int pos, string objeto)
        {
            int posicionOriginal = pos;
            if(numLibros > 0)
            {                
                string objetoABuscar = Interaction.InputBox("Añadir nombre a buscar");
                for(int i = 0; i < numLibros; i++)
                {
                    if(objeto == "titulo")
                    {
                        if(dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString().ToLower() == objetoABuscar.ToLower())
                        {
                            return i;
                        }
                    }
                    if(objeto == "autor")
                    {
                        if(dsLibros.Tables["Libros"].Rows[i]["Autor"].ToString().ToLower() == objetoABuscar.ToLower())
                        {
                            return i;
                        }
                    }
                }
                MessageBox.Show("No encontrado.");                
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
            return posicionOriginal;
        }
    }
}
