﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1T9
{
    internal class Libro
    {
        // Miembros
        private string id, titulo, autor, formato, idioma, leido;
        // Propiedades
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Autor
        {
            get { return autor; }
            set { autor = value; }
        }
        public string Formato
        {
            get { return formato; }
            set { formato = value; }
        }
        public string Idioma
        {
            get { return idioma; }
            set { idioma = value; }
        }
        public string Leido
        {
            get { return leido; }
            set { leido = value; }
        }

        // Constructor
        public Libro(string Id, string Titulo, string Autor, string Formato, string Idioma, string Leido)
        {
            id = Id;
            titulo = Titulo;
            autor = Autor;
            formato = Formato;
            idioma = Idioma;
            leido = Leido;
        }         
    }
}
