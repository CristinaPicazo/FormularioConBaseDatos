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
using System.Net;

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

        // Miembros para guardar el dataSet y el dataAdapter.
        private DataSet dsLibros;
        private SqlDataAdapter daLibros;
        
        // Miembro para guardar el número total.
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
            string cadenaConexion = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\AppData\\Libros.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection con = new SqlConnection(cadenaConexion);
            
            // Abrimos la conexión.
            con.Open();
            string cadenaSQL = "SELECT * From Libros";
            daLibros = new SqlDataAdapter(cadenaSQL, con);
            dsLibros = new DataSet();
            daLibros.Fill(dsLibros, "Libros");
            
            // Obtenemos el número de Libros
            numLibros = dsLibros.Tables["Libros"].Rows.Count;
            
            // Cerramos la conexión.
            con.Close();
        }

        // Método que a partir de una posición en la BD
        // Devuelve un objeto lilbro.
        // Devuelve null si pos está fuera de los límites
        public Libro devuelveLibro(int pos)
        {
            Libro libro = null;
            if(pos >= 0 && pos < numLibros)
            {
                // Objeto que nos permite recoger un registro de la tabla.
                DataRow dRegistro;
                // Cogemos el registro de la posición pos en la tabla
                dRegistro = dsLibros.Tables["Libros"].Rows[pos];
                // Cogemos el valor de cada una de las columnas del registro
                // y lo creamos el objeto con esos datos.
                libro = new Libro(                    
                    dRegistro["Id"].ToString(), 
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
        // Método que añade un libro a nuestra BD
        public void anadirLibro(Libro libro)
        {            
            // Creamos un nuevo registro.
            DataRow dRegistro = dsLibros.Tables["Libros"].NewRow();
            // Metemos los datos en el nuevo registro
            dRegistro["Id"] = libro.Id;
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

            // Actualizamos el número
            numLibros++;

        }

        public void actualizarLibro(Libro libro, int pos)
        {            
                // Cogemos el registro situado en la posición actual.
                DataRow dRegistro = dsLibros.Tables["Libros"].Rows[pos];
                // Metemos los datos en el registro
                dRegistro["Id"] = libro.Id;
                dRegistro["Titulo"] = libro.Titulo;
                dRegistro["Autor"] = libro.Autor;
                dRegistro["Formato"] = libro.Formato;
                dRegistro["Idioma"] = libro.Idioma;
                dRegistro["Leido"] = libro.Leido;

                // Reconectamos con el dataAdapter y actualizamos la BD
                SqlCommandBuilder cb = new SqlCommandBuilder(daLibros);
                daLibros.Update(dsLibros, "Libros");
        }
        public void eliminarLibro(int pos)
        {
            // Eliminamos el registro situado en la posición actual.
            dsLibros.Tables["Libros"].Rows[pos].Delete();
            
            // Tenemos uno menos
            numLibros--;
            
            // Reconectamos con el dataAdapter y actualizamos la BD
            SqlCommandBuilder cb = new SqlCommandBuilder(daLibros);
            daLibros.Update(dsLibros, "Libros");
        }

        public bool estaDuplicado(string titulo, string id)
        {
            bool duplicado = false;
            for(int i = 0; i < numLibros; i++)
            {
                if(dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString().ToLower() == titulo.ToLower())
                {
                    MessageBox.Show("Titulo duplicado");
                    duplicado = true;
                }
                if(dsLibros.Tables["Libros"].Rows[i]["Id"].ToString().ToLower() == id.ToLower())
                {
                    MessageBox.Show("Id duplicado");
                    duplicado = true;
                }

            }
            return duplicado;
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
            string listaLibros = "Libros:\n";
            if(numLibros > 0)
            {
                for(int i = 0; i < numLibros; i++)
                {

                    listaLibros += "\n" + ( i + 1 ) + ": " + dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString() + " de "
                                                   + dsLibros.Tables["Libros"].Rows[i]["Autor"].ToString();
                }
                return listaLibros;
            }
            else
            {
                return listaLibros = "No tiene libros.";
            }
        }
        public string listaLibrosIdioma(string idioma)
        {
            string listaLibros = "Libros en " + idioma + ":\n";
            int total = 0;
            if(numLibros > 0)
            {
                for(int i = 0; i < numLibros; i++)
                {
                    if(dsLibros.Tables["Libros"].Rows[i]["Idioma"].ToString() == idioma)
                    {
                        listaLibros += "\n" + ( i + 1 ) + " - " + dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString() + " de "
                                                   + dsLibros.Tables["Libros"].Rows[i]["Autor"].ToString();
                        total++;
                    }


                }
                return listaLibros += "\n\nTotal de libros encontrados: " + total;
            }
        else
        {
            return listaLibros = "No tiene libros.";
        }
    }
        public string listaLibrosLeido(string leido)
        {
            string listaLibros = "Libros " + leido + " leídos:\n";
            int total = 0;

            if(numLibros > 0)
            {
                for(int i = 0; i < numLibros; i++)
                {
                    if(dsLibros.Tables["Libros"].Rows[i]["Leido"].ToString() == leido)
                    {
                        listaLibros += "\n" + ( i + 1 ) + " - " + dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString() + " de "
                                                   + dsLibros.Tables["Libros"].Rows[i]["Autor"].ToString();
                        total++;

                    }
                }
                return listaLibros += "\n\nTotal de libros encontrados: " + total; ;
            }
        else
        {
            return listaLibros = "No tiene libros.";
        }
    }
        public string listaLibrosFormato(string formato)
        {
            string listaLibros = "Libros en " + formato + ":\n";
            int total = 0;

            if(numLibros > 0)
            {
                for(int i = 0; i < numLibros; i++)
                {                     
                        if(dsLibros.Tables["Libros"].Rows[i]["Formato"].ToString() == formato)
                        {
                            listaLibros += "\n" + ( i + 1 ) + " - " + dsLibros.Tables["Libros"].Rows[i]["Titulo"].ToString() + " de "
                                                       + dsLibros.Tables["Libros"].Rows[i]["Autor"].ToString();
                        total++;

                    }
                }
                return listaLibros += "\n\nTotal de libros encontrados: " + total; ;
            }
        else
        {
            return listaLibros = "No tiene libros.";
        }
    }

        public int buscarLibros(int pos, string objeto)
        {
            int posicionOriginal = pos;
            if(numLibros > 0)
            {                
                string objetoABuscar = Interaction.InputBox("Añadir nombre a buscar");
                if(objetoABuscar!= ""){

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
                    sugerenciaBusqueda(objeto,objetoABuscar);
                }
                else
                {
                    MessageBox.Show("No has escrito nada.");
                }
            }
            else
            {
                MessageBox.Show("La lista esta vacía");
            }
            return posicionOriginal;
        }

        public void sugerenciaBusqueda(string objeto, string objetoABuscar)
        {
            string texto = "Posibles libros:\n";
            List<Libro> lista = new List<Libro>();

            DataRow[] registroParecido;
            if(objeto == "titulo")
            {
                registroParecido = dsLibros.Tables["Libros"].Select("Titulo Like '%" + objetoABuscar + "%'");

                for(int i = 0; i < registroParecido.Length; i++)
                {
                    DataRow registro;
                    registro = registroParecido[i];

                    texto += "\n" + registro["Titulo"].ToString() + " de " + registro["Autor"].ToString();

                }
            }
            if(objeto == "autor")
            {
                registroParecido = dsLibros.Tables["Libros"].Select("Autor Like '%" + objetoABuscar + "%'");

                for(int i = 0; i < registroParecido.Length; i++)
                {
                    DataRow registro;
                    registro = registroParecido[i];

                    texto += "\n" + registro["Titulo"].ToString() + " " + registro["Autor"].ToString();

                }
            }

                MessageBox.Show(texto);
        }
    }
}
